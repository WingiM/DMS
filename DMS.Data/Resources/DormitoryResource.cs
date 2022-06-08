using System.Text;
using DMS.Core.Exceptions;
using DMS.Core.Objects.Dormitory;
using DMS.Data.Models;
using Microsoft.Extensions.Caching.Distributed;

namespace DMS.Data.Resources;

public class DormitoryResource : ResourceBase, IDormitoryResource
{
    private readonly IDistributedCache _cache;

    public DormitoryResource(IDistributedCache cache,
        ApplicationContext context) : base(context)
    {
        _cache = cache;
    }

    private string GetConstant(string key)
    {
        return _cache.GetString(key);
    }

    public PriceConstants GetPriceConstants()
    {
        try
        {
            var commercial = int.Parse(GetConstant("CommercialCost"));
            var nonCommercial = int.Parse(GetConstant("NonCommercialCost"));

            return new PriceConstants(commercial, nonCommercial);
        }
        catch (ArgumentNullException)
        {
            throw new ConstantException("Price constant values not set");
        }
    }

    public ResetConstants GetResetConstants()
    {
        try
        {
            var floors = int.Parse(GetConstant("Floors"));
            var count = int.Parse(GetConstant("RoomsCount"));
            var capacity = int.Parse(GetConstant("RoomCapacity"));

            return new ResetConstants(floors, count, capacity);
        }
        catch (ArgumentNullException)
        {
            throw new ConstantException("Reset constants values not set");
        }
    }

    public void SetConstants(PriceConstants priceConstants)
    {
        foreach (var constant in priceConstants)
        {
            var value = constant.Value.ToString();
            if (int.Parse(value) > 0)
            {
                _cache.Set(constant.Key, Encoding.UTF8.GetBytes(value));
            }
        }
    }

    public void SetConstants(ResetConstants resetConstants)
    {
        foreach (var constant in resetConstants)
            _cache.Set(constant.Key,
                Encoding.UTF8.GetBytes(constant.Value.ToString()));
    }


    public DormitorySettlementData GetDormitoryData()
    {
        return new DormitorySettlementData
        {
            SettledBedPlaces = Context.Residents.Count(r => r.RoomId != null),
            TotalBedPlaces = Context.Rooms.Sum(r => r.Capacity)
        };
    }
}