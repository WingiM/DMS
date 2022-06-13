using DMS.Core.Objects.ServiceInterfaces;

namespace DMS.Core.Objects.Rooms;

public class RoomService : IRoomService
{
    private readonly IRoomResource _roomResource;
    private readonly IDataContext _dataContext;
    
    public RoomService(IRoomResource roomResource, IDataContext dataContext)
    {
        _roomResource = roomResource;
        _dataContext = dataContext;
    }
    
    // public Room GetRoomWithResidents(int id, DateTime documentsDate)
    // {
    //     return _roomResource.GetRoom(id, documentsDate);
    // }
    //
    // public IEnumerable<int> GetFloorsCount()
    // {
    //     return _roomResource.GetFloorsCount();
    // }
    //
    // public IEnumerable<Room> GetAllRoomsOnFloor(int floorNumber)
    // {
    //     return _roomResource.GetAllRoomsOnFloor(floorNumber);
    // }
    //
    // public void SetRoomGender(string data)
    // {
    //     _roomResource.SetRoomGender(data);
    // }
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

    public void SetRoomGender(int roomNumber, string gender)
    {
        var room = _roomResource.GetRoom(roomNumber);
        room.Gender = char.Parse(gender);
        
        _roomResource.UpdateRoom(room);
        _dataContext.SaveChanges();
    }
}