using System.Text;
using DMS.Models;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace DMS.Resources;

public class DormitoryResource
{
    private static readonly string[] SafeConstants =
    {
        "CommercialCost", "NonCommercialCost"
    };

    private static readonly string[] HardResetConstants =
    {
        "Floors", "RoomsCount", "RoomCapacity"
    };

    private static readonly Dictionary<string, Predicate<int>>
        HardResetConstantsConstraints = new()
        {
            { "Floors", x => x is < 10 and > 0 },
            { "RoomsCount", x => x is < 100 and > 0 },
            { "RoomCapacity", x => x > 0 }
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

    public Tuple<bool, string> SetSafeConstants(string data)
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

        foreach (var key in SafeConstants)
        {
            if (!constants.ContainsKey(key) ||
                !int.TryParse(constants[key], out var res) ||
                res < 0)
            {
                unusedKeys.Add(key);
                continue;
            }

            _cache.Set(key, Encoding.UTF8.GetBytes(constants[key]!));
        }

        return new Tuple<bool, string>(true, string.Join(", ", unusedKeys));
    }

    public Dictionary<string, string> GetConstants()
    {
        var res = new Dictionary<string, string>();
        foreach (var key in SafeConstants.Concat(HardResetConstants))
        {
            res.Add(key, _cache.GetString(key));
        }

        return res;
    }

    public Tuple<bool, string?> SetHardResetConstants(string data)
    {
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
            return new Tuple<bool, string?>(false,
                "Could not parse request body");

        foreach (var key in HardResetConstants)
        {
            if (!constants.ContainsKey(key))
                return new Tuple<bool, string?>(false, $"No value for {key}");

            if (!int.TryParse(constants[key], out var res) ||
                !HardResetConstantsConstraints[key](res))
            {
                return new Tuple<bool, string?>(false,
                    $"Incorrect value for {res}");
            }
        }

        foreach (var pair in constants)
        {
            _cache.Set(pair.Key, Encoding.UTF8.GetBytes(pair.Value!));
        }

        return new Tuple<bool, string?>(true, null);
    }

    public Tuple<bool, string?> ResetRooms()
    {
        var constants = new Dictionary<string, int>
        {
            { "Floors", int.Parse(GetConstant("Floors")) },
            { "RoomsCount", int.Parse(GetConstant("RoomsCount")) },
            { "RoomCapacity", int.Parse(GetConstant("RoomCapacity")) }
        };

        _context.Rooms.RemoveRange(_context.Rooms);

        for (int i = 2; i < constants["Floors"] + 2; ++i)
        {
            for (int j = 1; j < constants["RoomsCount"] + 1; j++)
            {
                var room = new Room
                {
                    Capacity = constants["RoomCapacity"],
                    Gender = i == 2 ? 'F' : 'M',
                    RoomId = int.Parse($"{i}{j:00}")

                };
                _context.Rooms.Add(room);
            }
        }
        
        try
        {
            _context.SaveChanges();
        }
        catch (DbUpdateException)
        {
            return new Tuple<bool, string?>(false, "Could not add new rooms");
        }

        return new Tuple<bool, string?>(true, null);
    }

    public string GetConstant(string key)
    {
        return _cache.GetString(key);
    }
}