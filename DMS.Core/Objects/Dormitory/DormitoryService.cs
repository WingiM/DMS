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
    
    public void ResetDormitoryRooms()
    {
        var constants = GetResetConstants();
        Context.Rooms.RemoveRange(Context.Rooms);
        for (int i = 2; i < constants["Rooms"] + 2; ++i)
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

    public string GetConstant(string key)
    {
        return _dormitoryResource.GetConstant(key);
    }
}