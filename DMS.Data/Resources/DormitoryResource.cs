using System.Text;
using System.Text.Json;
using DMS.Core.Exceptions;
using DMS.Core.Objects.Dormitory;
using DMS.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;

namespace DMS.Data.Resources;

public class DormitoryResource : ResourceBase, IDormitoryResource
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
    
    private readonly IDistributedCache _cache;

    public DormitoryResource(IDistributedCache cache, ApplicationContext context) : base(context)
    {
        _cache = cache;
    }

    public Dictionary<string, int> GetDormitoryCapacity()
    {
        return new Dictionary<string, int>
        {
            { "Settled", Context.Residents.Count(r => r.RoomId != null) },
            { "Total", Context.Rooms.Sum(r => r.Capacity) }
        };
    }

    public string SetSafeConstants(string data)
    {
        try
        {
            var unusedKeys = new List<string?>();
            var constants =
                JsonSerializer.Deserialize<Dictionary<string, string?>>(data);

            foreach (var key in SafeConstants)
            {
                if (!constants!.ContainsKey(key) ||
                    !int.TryParse(constants[key], out var res) ||
                    res < 0)
                {
                    unusedKeys.Add(key);
                    continue;
                }

                _cache.Set(key, Encoding.UTF8.GetBytes(constants[key]!));
            }

            return string.Join(", ", unusedKeys);
        }
        catch (NullReferenceException e)
        {
            throw new InvalidRequestDataException(
                "Could not deserialize request body", e);
        }
        catch (Exception e)
        {
            throw new Exception(GetExceptionMessage(e), e);
        }
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

    public void SetHardResetConstants(string data)
    {
        try
        {
            var constants =
                JsonSerializer.Deserialize<Dictionary<string, string?>>(data);

            foreach (var key in HardResetConstants)
            {
                if (!constants!.ContainsKey(key))
                    throw new InvalidRequestDataException(
                        $"No value for {key}");

                if (!int.TryParse(constants[key], out var res) ||
                    !HardResetConstantsConstraints[key](res))
                {
                    throw new InvalidRequestDataException(
                        $"Incorrect value for {res}");
                }
            }

            foreach (var pair in constants!)
            {
                _cache.Set(pair.Key, Encoding.UTF8.GetBytes(pair.Value!));
            }
        }
        catch (NullReferenceException e)
        {
            throw new InvalidRequestDataException(
                "Could not deserialize request body", e);
        }
        catch (Exception e)
        {
            throw new Exception(GetExceptionMessage(e), e);
        }
    }

    public void ResetRooms()
    {
        try
        {
            var constants = new Dictionary<string, int>
            {
                { "Floors", int.Parse(GetConstant("Floors")) },
                { "RoomsCount", int.Parse(GetConstant("RoomsCount")) },
                { "RoomCapacity", int.Parse(GetConstant("RoomCapacity")) }
            };

            Context.Rooms.RemoveRange(Context.Rooms);

            for (int i = 2; i < constants["Floors"] + 2; ++i)
            {
                for (int j = 1; j < constants["RoomsCount"] + 1; j++)
                {
                    var room = new RoomDb
                    {
                        Capacity = constants["RoomCapacity"],
                        Gender = i == 2 ? 'F' : 'M',
                        RoomId = int.Parse($"{i}{j:00}")
                    };
                    Context.Rooms.Add(room);
                }
            }
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }

    public string GetConstant(string key)
    {
        return _cache.GetString(key);
    }
}