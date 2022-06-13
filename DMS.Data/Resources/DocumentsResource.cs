using System.Data;
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

    public IEnumerable<RatingChangeCategory> GetAllRatingChangeCategories()
    {
        return Context.RatingChangeCategories.Select(
            ConvertRatingChangeCategory);
    }

    public IEnumerable<Resident> GetAllDocuments()
    {
        return GetAllDocuments(DateTime.MinValue);
    }

    public IEnumerable<Resident> GetAllDocuments(DateTime documentsStartDate)
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
            .Select(ConvertResident);
    }

    public void AddDocument<T>(T document) where T : IDocument
    {
        switch (document)
        {
            case Transaction t:
                CreateTransaction(t);
                break;
            case RatingOperation ro:
                CreateRatingOperation(ro);
                break;
            case SettlementOrder so:
                CreateSettlementOrder(so);
                break;
            case EvictionOrder eo:
                CreateEvictionOrder(eo);
                break;
        }
    }

    public void UpdateResidentRoomAfterOrder(IOrder order, int? room)
    {
        var resident =
            Context.Residents.FirstOrDefault(r =>
                r.ResidentId == order.Resident.Id) ??
            throw new DataException("Resident not found");

        resident.RoomId = room;
    }

    public void DeleteDocument<T>(T document) where T : IDocument
    {
        switch (document)
        {
            case Transaction t:
                var transactionDb =
                    Context.Transactions.FirstOrDefault(tr =>
                        tr.TransactionId == t.Id) ??
                    throw new DataException("Transaction not found");
                Context.Transactions.Remove(transactionDb);
                break;
            case RatingOperation ro:
                var ratingOperationDb =
                    Context.RatingOperations.FirstOrDefault(ratingOp =>
                        ratingOp.RatingOperationId == ro.Id) ??
                    throw new DataException("Rating operation not found");
                Context.RatingOperations.Remove(ratingOperationDb);
                break;
            case SettlementOrder:
            case EvictionOrder:
                throw new DataException("Orders cannot be deleted");
            default:
                throw new DataException(
                    "Document type is unknown or unspecified");
        }
    }

    private void CreateSettlementOrder(SettlementOrder so)
    {
        var resident =
            Context.Residents.FirstOrDefault(
                r => r.ResidentId == so.Resident.Id) ??
            throw new DataException("Resident not found");
        var room = Context.Rooms.FirstOrDefault(r => r.RoomId == so.Room.Id) ??
                   throw new DataException("Room not found");

        if (resident.RoomId != null)
            throw new DataException("Resident already has a room.");

        if (Context.Residents.Count(r => r.RoomId == room.RoomId) ==
            room.Capacity)
            throw new DataException("Room is overcrowded");

        var settlementOrderDb = new SettlementOrderDb
        {
            SettlementOrderId = so.Id, Description = so.Description,
            OrderDate = so.PostDate, ResidentId = so.Resident.Id,
            RoomId = so.Room.Id,
            ParentsFullName = so.ParentData.ParentsFullName,
            ParentsPassportAddress = so.ParentData.ParentsPassportAddress,
            ParentsPassportDepartmentCode =
                so.ParentData.ParentsPassportDepartmentCode,
            ParentsPassportIssueDate = so.ParentData.ParentsPassportIssueDate,
            ParentsPassportIssuedBy = so.ParentData.ParentsPassportIssuedBy,
            ParentsPassportSeriesNumber =
                so.ParentData.ParentsPassportSeriesNumber
        };
        Context.SettlementOrders.Add(settlementOrderDb);
    }

    private void CreateEvictionOrder(EvictionOrder eo)
    {
        if (Context.Residents.FirstOrDefault(
                r => r.ResidentId == eo.Resident.Id) is null)
            throw new DataException("Resident not found");

        var evictionOrderDb = new EvictionOrderDb
        {
            EvictionOrderId = eo.Id, Description = eo.Description,
            OrderDate = eo.PostDate, ResidentId = eo.Resident.Id
        };

        Context.EvictionOrders.Add(evictionOrderDb);
    }

    private void CreateRatingOperation(RatingOperation ro)
    {
        if (Context.Residents.FirstOrDefault(
                r => r.ResidentId == ro.Resident.Id) is null)
            throw new DataException("Resident not found");
        
        var ratingOperationDb = new RatingOperationDb
        {
            RatingOperationId = ro.Id, CategoryId = ro.Category.Id,
            Description = ro.Description, ChangeValue = ro.ChangeValue,
            OrderDate = ro.PostDate, ResidentId = ro.Resident.Id
        };
        Context.RatingOperations.Add(ratingOperationDb);
    }

    private void CreateTransaction(Transaction t)
    {
        if (Context.Residents.FirstOrDefault(
                r => r.ResidentId == t.Resident.Id) is null)
            throw new DataException("Resident not found");
        
        var transactionDb = new TransactionDb
        {
            TransactionId = t.Id, ResidentId = t.Resident.Id,
            OperationDate = t.PostDate, Sum = t.Sum
        };
        Context.Transactions.Add(transactionDb);
    }
}