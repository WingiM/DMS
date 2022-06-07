using System.Text.Json;
using DMS.Core.Objects.Residents;
using DMS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS.Data.Resources;

public class ResidentResource : ResourceBase, IResidentResource
{
    public ResidentResource(ApplicationContext context) : base(context)
    {
    }

    public IEnumerable<Resident> GetAllResidents()
    {
        return Context.Residents
            .OrderBy(r => r.RoomId == null)
            .ThenBy(r => r.LastName)
            .Select(ConvertResident);
    }

    public IEnumerable<Resident> GetAllResidents(DateTime documentsStartDate, string gender)
    {
        return GetAllResidents().Where(r => r.Gender == char.Parse(gender));
    }

    public Resident GetResidentById(int id, DateTime documentsStartDate)
    {
        Context.Transactions
            .Where(t =>
                t.ResidentId == id && t.OperationDate > documentsStartDate)
            .Load();
        Context.RatingOperations.Where(ro =>
                ro.ResidentId == id && ro.OrderDate > documentsStartDate)
            .Load();
        Context.Passports.Load();
        Context.RatingChangeCategories.Load();

        return ConvertResidentWithDocuments(
            Context.Residents.First(r => r.ResidentId == id));
    }

    public Resident GetResidentById(int id)
    {
        return GetResidentById(id, DateTime.MinValue);
    }

    public void AccrualAll(int commercialCost, int nonCommercialCost)
    {
        try
        {
            foreach (var resident in Context.Residents)
            {
                if (resident.RoomId is null)
                    continue;

                var transaction = new TransactionDb
                {
                    ResidentId = resident.ResidentId,
                    OperationDate = DateTime.UtcNow,
                    Sum = resident.IsCommercial
                        ? commercialCost
                        : nonCommercialCost
                };

                Context.Transactions.Add(transaction);
            }
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }

    public void ResetAll()
    {
        try
        {
            foreach (var resident in Context.Residents)
            {
                if (resident.RoomId is null)
                    continue;

                var order = new EvictionOrderDb
                {
                    ResidentId = resident.ResidentId,
                    OrderDate = DateTime.UtcNow,
                    Description = "Dormitory reset"
                };

                Context.EvictionOrders.Add(order);
                resident.RoomId = null;
                resident.Course++;
            }
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }

    public int AddResident(string data)
    {
        try
        {
            var resident = JsonSerializer.Deserialize<ResidentDb>(data);

            if (resident!.RoomId is not null)
                throw new Exception(
                    "Cannot specify room id in resident creation");

            Context.Residents.Add(resident);
            return resident.ResidentId;
        }
        catch (Exception e)
        {
            throw new Exception(GetExceptionMessage(e), e);
        }
    }

    public void UpdateResident(int id, string data)
    {
        try
        {
            var stored = Context.Residents.AsNoTracking()
                .First(r => r.ResidentId == id);

            var resident = JsonSerializer.Deserialize<ResidentDb>(data);
            resident!.ResidentId = stored.ResidentId;
            resident.RoomId = stored.RoomId;
            resident.PassportInformation.PassportInformationId =
                Context.Passports.AsNoTracking().FirstOrDefault(p =>
                    p.ResidentId == id)!.PassportInformationId;
            Context.Update(resident.PassportInformation);

            Context.Residents.Update(resident);
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException("No resident with this Id", e);
        }
        catch (Exception e)
        {
            throw new Exception(GetExceptionMessage(e), e);
        }
    }

    public void DeleteResident(int id)
    {
        try
        {
            var resident =
                Context.Residents.First(r => r.ResidentId == id);
            Context.Residents.Remove(resident);
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException("No resident with this Id", e);
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }
}