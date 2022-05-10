using System.Text;
using DMS.Models;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace DMS.Resources;

public class DormitoryResource
{
    private static readonly string[] CacheStrings =
    {
        "Floors", "RoomsCount", "RoomCapacity",
        "CommercialCost", "NonCommercialCost"
    };

    private readonly ILogger<DormitoryResource> _logger;
    private readonly IDistributedCache _cache;
    private readonly ApplicationContext _context;

    public DormitoryResource(ILogger<DormitoryResource> logger,
        IDistributedCache cache, ApplicationContext context)
    {
        _logger = logger;
        _cache = cache;
        _context = context;
    }

    public Dictionary<string, int> GetDormitoryCapacity()
    {
        return new Dictionary<string, int>
        {
            { "Settled", _context.Residents.Count(r => r.RoomId != null) },
            { "Total", _context.Rooms.Sum(r => r.Capacity) }
        };
    }

    public Tuple<bool, string> SetConstants(string data)
    {
        var unusedKeys = new List<string?>();
        Dictionary<string, string?>? constants = null;
        try
        {
            constants =
                JsonSerializer.Deserialize<Dictionary<string, string?>>(data);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information, e.ToString());
        }

        if (constants is null)
            return new Tuple<bool, string>(false,
                "Could not parse request body");

        foreach (var pair in constants)
        {
            if (CacheStrings.Contains(pair.Key) && pair.Value is not null &&
                int.TryParse(pair.Value, out _))
            {
                _cache.Set(pair.Key, Encoding.UTF8.GetBytes(pair.Value));
            }
            else
                unusedKeys.Add(pair.Key);
        }

        return new Tuple<bool, string>(true, string.Join(", ", unusedKeys));
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

    public string GetConstant(string key)
    {
        return _cache.GetString(key);
    }
}