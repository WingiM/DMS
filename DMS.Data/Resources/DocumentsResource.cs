using System.Text.Json;
using DMS.Core.Exceptions;
using DMS.Core.Objects.Documents;
using DMS.Core.Objects.Documents.Interfaces;
using DMS.Core.Objects.Residents;
using DMS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS.Data.Resources;

public class DocumentsResource : ResourceBase, IDocumentsResource
{
    public DocumentsResource(ApplicationContext context) : base(context)
    {
    }

    public IEnumerable<Resident> GetAllDocuments()
    {
        return GetAllDocuments(DateTime.MinValue);
    }

    public IEnumerable<Resident> GetAllDocuments(
        DateTime documentsStartDate)
    {
        Context.Transactions.Where(t => t.OperationDate > documentsStartDate)
            .Load();
        Context.RatingOperations.Where(ro => ro.OrderDate > documentsStartDate)
            .Load();
        Context.SettlementOrders.Where(so => so.OrderDate > documentsStartDate)
            .Load();
        Context.EvictionOrders.Where(eo => eo.OrderDate > documentsStartDate)
            .Load();
        Context.Passports.Load();
        Context.RatingChangeCategories.Load();
        return Context.Residents
            .OrderBy(r => r.RoomId == null)
            .ThenBy(r => r.LastName)
            .Select(ConvertResidentWithDocuments);
    }

    public void AddDocument<T>(T document) where T : class
    {
        switch (document)
        {
            case TransactionDb t:
                CreateTransaction(t);
                break;
            case RatingOperationDb ro:
                CreateRatingOperation(ro);
                break;
            case SettlementOrderDb so:
                CreateSettlementOrder(so);
                break;
            case EvictionOrderDb eo:
                CreateEvictionOrder(eo);
                break;
        }
    }

    public void DeleteDocument<T>(T document) where T : class
    {
        switch (document)
        {
            case TransactionDb t:
                Context.Transactions.Remove(t);
                break;
            case RatingOperationDb ro:
                Context.RatingOperations.Remove(ro);
                break;
            case SettlementOrderDb:
            case EvictionOrderDb:
                throw new InvalidRequestDataException(
                    "Orders cannot be deleted");
            default:
                throw new InvalidRequestDataException(
                    "Document type is unknown or unspecified");
        }
    }

    public IEnumerable<RatingChangeCategory> GetAllRatingChangeCategories()
    {
        return Context.RatingChangeCategories.Select(
            ConvertRatingChangeCategory);
    }

    private void CreateSettlementOrder(SettlementOrderDb so)
    {
        try
        {
            var resident =
                Context.Residents.First(r => r.ResidentId == so.ResidentId);
            var room = Context.Rooms.First(r => r.RoomId == so.RoomId);

            if (resident.RoomId != null)
                throw new Exception("Resident already has a room.");

            if (Context.Residents.Count(r => r.RoomId == room.RoomId) ==
                room.Capacity)
                throw new Exception("Room is overcrowded");

            Context.SettlementOrders.Add(so);
            Context.SaveChanges();

            resident.RoomId = so.RoomId;
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException("Invalid room or resident id",
                e);
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }

    private void CreateEvictionOrder(EvictionOrderDb eo)
    {
        try
        {
            var resident =
                Context.Residents.First(r => r.ResidentId == eo.ResidentId);

            if (resident.RoomId is null)
                throw new Exception("Resident is already evicted");

            Context.EvictionOrders.Add(eo);
            resident.RoomId = null;
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException("Invalid resident id", e);
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }

    private void CreateRatingOperation(RatingOperationDb ro)
    {
        try
        {
            var resident =
                Context.Residents.First(r => r.ResidentId == ro.ResidentId);

            if (resident.RoomId is null)
                throw new Exception("Resident is evicted");

            Context.RatingOperations.Add(ro);
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException("Invalid resident id", e);
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }

    private void CreateTransaction(TransactionDb t)
    {
        try
        {
            var resident =
                Context.Residents.First(r => r.ResidentId == t.ResidentId);

            if (resident.RoomId is null)
                throw new Exception("Resident is evicted");

            Context.Transactions.Add(t);
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException("Invalid resident id", e);
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }
}