using System.Globalization;
using System.Text;
using DMS.Models;
using Microsoft.Extensions.Caching.Distributed;

namespace DMS.Resources;

public class DormitoryResource
{
    private static readonly DateTime DefaultDocumentStartDate =
        DateTime.Now.Month >= 9
            ? new DateTime(DateTime.Now.Year, 9, 1)
            : new DateTime(DateTime.Now.Year - 1, 9, 1);

    private static readonly string[] CacheStrings = {
        "Floors", "RoomsCount", "RoomCapacity", 
        "CommercialCost", "NonCommercialCost"
    };

    private readonly ILogger<DormitoryResource> _logger;
    private readonly IDistributedCache _cache;
    private readonly ApplicationContext _context;

    internal static DateTime ParseDate(string date)
    {
        DateTime.TryParseExact(date, "d", null, DateTimeStyles.None,
            out var result);
        return (result == DateTime.MinValue ? DefaultDocumentStartDate : result)
            .ToUniversalTime().Date;
    }

    public DormitoryResource(ILogger<DormitoryResource> logger,
        IDistributedCache cache, ApplicationContext context)
    {
        _logger = logger;
        _cache = cache;
        _context = context;
    }

    public Dictionary<string, int> GetDormitoryCapacity()
    {
        return new Dictionary<string, int>()
        {
            { "Settled", _context.Residents.Count(r => r.RoomId != null) },
            { "Total", _context.Rooms.Sum(r => r.Capacity) }
        };
    }

    public void SetConstants(Dictionary<string, string?> constants)
    {
        foreach (var pair in constants)
        {
            if (CacheStrings.Contains(pair.Key) && pair.Value is not null)
                _cache.Set(pair.Key, Encoding.UTF8.GetBytes(pair.Value));
        }
    }

    public Dictionary<string, string> GetConstants()
    {
        var res = new Dictionary<string, string>();
        foreach (var key in CacheStrings)
        {
            res.Add(key, _cache.GetString(key));
        }

        return res;
    }
}