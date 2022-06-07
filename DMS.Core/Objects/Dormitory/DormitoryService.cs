using DMS.Core.Objects.ServiceInterfaces;

namespace DMS.Core.Objects.Dormitory;

public class DormitoryService : IDormitoryService
{
    private readonly IDormitoryResource _dormitoryResource;

    public DormitoryService(IDormitoryResource dormitoryResource)
    {
        _dormitoryResource = dormitoryResource;
    }


    public Dictionary<string, int> GetDormitoryCapacity()
    {
        return _dormitoryResource.GetDormitoryData();
    }

    public string SetSafeConstants(string data)
    {
        return _dormitoryResource.SetConstants(data);
    }

    public Dictionary<string, string> GetConstants()
    {
        return _dormitoryResource.GetConstants();
    }

    public void SetHardResetConstants(string data)
    {
        _dormitoryResource.SetHardResetConstants(data);
    }

    public void ResetRooms()
    {
        _dormitoryResource.ResetDormitoryRooms();
    }

    public string GetConstant(string key)
    {
        return _dormitoryResource.GetConstant(key);
    }
}