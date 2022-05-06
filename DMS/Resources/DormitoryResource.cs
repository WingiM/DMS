using System.Globalization;
using System.Text;
using Microsoft.Extensions.Caching.Distributed;

namespace DMS.Resources;

public class DormitoryResource
{
    private static readonly DateTime DefaultDocumentStartDate =
        DateTime.Now.Month >= 9
            ? new DateTime(DateTime.Now.Year, 9, 1)
            : new DateTime(DateTime.Now.Year - 1, 9, 1);

    private static readonly string[] CacheStrings = {
        "floors", "roomsCount", "roomCapacity", "commercialCost",
        "nonCommercialCost", "encryptedPassword"
    };

    private ILogger<DormitoryResource> _logger;
    private IDistributedCache _cache;

    internal static DateTime ParseDate(string date)
    {
        DateTime.TryParseExact(date, "d", null, DateTimeStyles.None,
            out var result);
        return (result == DateTime.MinValue ? DefaultDocumentStartDate : result)
            .ToUniversalTime().Date;
    }

    public DormitoryResource(ILogger<DormitoryResource> logger,
        IDistributedCache cache)
    {
        _logger = logger;
        _cache = cache;
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