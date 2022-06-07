using DMS.Core.Objects.ServiceInterfaces;

namespace DMS.Core.Objects.Rooms;

public class RoomService : IRoomService
{
    private readonly IRoomResource _roomResource;
    
    public RoomService(IRoomResource roomResource)
    {
        _roomResource = roomResource;
    }
    
    public Room GetRoomWithResidents(int id, DateTime documentsDate)
    {
        return _roomResource.GetRoom(id, documentsDate);
    }

    public IEnumerable<int> GetFloorsCount()
    {
        return _roomResource.GetFloorsCount();
    }

    public IEnumerable<Room> GetAllRoomsOnFloor(int floorNumber)
    {
        return _roomResource.GetAllRoomsOnFloor(floorNumber);
    }

    public void SetRoomGender(string data)
    {
        _roomResource.SetRoomGender(data);
    }
}