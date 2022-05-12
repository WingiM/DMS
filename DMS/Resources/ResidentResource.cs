using System.Text.Json;
using DMS.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS.Resources;

public class ResidentResource : ResourceBase
{
    private readonly ApplicationContext _context;
    private readonly ILogger<ResidentResource> _logger;

    public ResidentResource(ApplicationContext context,
        ILogger<ResidentResource> logger)
    {
        _context = context;
        _logger = logger;
    }


    public IEnumerable<Resident> GetAllResidents(DateTime documentsStartDate)
    {
        _context.Transactions.Where(t => t.OperationDate > documentsStartDate)
            .Load();
        _context.RatingOperations.Where(ro => ro.OrderDate > documentsStartDate)
            .Load();
        _context.Passports.Load();
        _context.RatingChangeCategories.Load();

        return _context.Residents
            .OrderBy(r => r.RoomId == null)
            .ThenBy(r => r.LastName);
    }

    public IEnumerable<Resident> GetAllResidents()
    {
        _context.Transactions.Load();
        _context.RatingOperations.Load();
        _context.RatingChangeCategories.Load();
        _context.SettlementOrders.Load();
        _context.EvictionOrders.Load();
        _context.Passports.Load();

        return _context.Residents
            .OrderBy(r => r.RoomId == null)
            .ThenBy(r => r.LastName);
    }

    public IEnumerable<Resident> GetAllResidents(DateTime documentsStartDate,
        string? gender)
    {
        var res = GetAllResidents(documentsStartDate);
        if (gender is not null)
            return res.Where(r => r.Gender == char.Parse(gender));
        return res
            .OrderBy(r => r.RoomId == null)
            .ThenBy(r => r.LastName);
    }

    public Resident GetResidentById(int id, DateTime documentsStartDate)
    {
        _context.Transactions
            .Where(t =>
                t.ResidentId == id && t.OperationDate > documentsStartDate)
            .Load();
        _context.RatingOperations.Where(ro =>
                ro.ResidentId == id && ro.OrderDate > documentsStartDate)
            .Load();
        _context.Passports.Load();
        _context.RatingChangeCategories.Load();

        return _context.Residents.First(r => r.ResidentId == id);
    }

    public Resident GetResidentById(int id)
    {
        _context.Transactions
            .Where(t => t.ResidentId == id).Load();
        _context.RatingOperations.Where(ro => ro.ResidentId == id).Load();
        _context.Passports.Load();
        _context.RatingChangeCategories.Load();

        return _context.Residents.First(r => r.ResidentId == id);
    }

    public void AccrualAll(int commercialCost, int nonCommercialCost)
    {
        try
        {
            foreach (var resident in _context.Residents)
            {
                if (resident.RoomId is null)
                    continue;

                var transaction = new Transaction
                {
                    ResidentId = resident.ResidentId,
                    OperationDate = DateTime.UtcNow,
                    Sum = resident.IsCommercial
                        ? commercialCost
                        : nonCommercialCost
                };

                _context.Transactions.Add(transaction);
            }

            _context.SaveChanges();
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }

    public void EvictAll()
    {
        try
        {
            foreach (var resident in _context.Residents)
            {
                if (resident.RoomId is null)
                    continue;

                var order = new EvictionOrder
                {
                    ResidentId = resident.ResidentId,
                    OrderDate = DateTime.UtcNow,
                    Description = "Dormitory reset"
                };

                _context.EvictionOrders.Add(order);
                resident.RoomId = null;
            }

            _context.SaveChanges();
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }

    public void AddResident(string data)
    {
        try
        {
            var resident = JsonSerializer.Deserialize<Resident>(data);
            _context.Residents.Add(resident!);
            _context.SaveChanges();
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information, "Failed to insert resident");
            throw new Exception(GetExceptionMessage(e), e);
        }
    }

    public void UpdateResident(int id, string data)
    {
        try
        {
            var stored = _context.Residents.AsNoTracking()
                .First(r => r.ResidentId == id);

            var resident = JsonSerializer.Deserialize<Resident>(data);
            resident!.ResidentId = stored.ResidentId;
            resident.RoomId = stored.RoomId;
            if (resident.PassportInformation is not null)
            {
                resident.PassportInformation.PassportInformationId =
                    _context.Passports.AsNoTracking().FirstOrDefault(p =>
                        p.ResidentId == id)!.PassportInformationId;
                _context.Update(resident.PassportInformation);
            }

            _context.Residents.Update(resident);
            _context.SaveChanges();
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException("No resident with this Id", e);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information, "Failed to update resident");
            throw new Exception(GetExceptionMessage(e), e);
        }
    }

    public void DeleteResident(int id)
    {
        try
        {
            var resident =
                _context.Residents.First(r => r.ResidentId == id);
            _context.Residents.Remove(resident);
            _context.SaveChanges();
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