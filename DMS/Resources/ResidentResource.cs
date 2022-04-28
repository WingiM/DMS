using System.Collections;
using DMS.Models;

namespace DMS.Resources;

public class ResidentResource
{
    private readonly ApplicationContext _context;
    private readonly ILogger<ResidentResource> _logger;

    public ResidentResource(ApplicationContext context, ILogger<ResidentResource> logger)
    {
        _context = context;
        _logger = logger;
        _logger.Log(LogLevel.Debug, "ResidentResource!");
    }

    public IEnumerable GetAllResidents()
    {
        return _context.Residents.Select(r => new
        {
            r.ResidentId, r.LastName, r.FirstName, r.Patronymic, r.Gender,
            r.PassportInformation, r.Tin, r.BirthDate
        });
    }

    public bool DeleteResident(int id)
    {
        var resident =
            _context.Residents.FirstOrDefault(r => r.ResidentId == id);
        if (resident is null)
            return false;

        _logger.Log(LogLevel.Debug, "I'm working!");
        _context.Residents.Remove(resident);
        _context.SaveChanges();
        return true;
    }
}