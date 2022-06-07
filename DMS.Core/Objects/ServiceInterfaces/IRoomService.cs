using DMS.Core.Objects.Rooms;

namespace DMS.Core.Objects.ServiceInterfaces;

public interface IRoomService
{
    public Room GetRoomWithResidents(int id, DateTime documentsDate);
    public IEnumerable<int> GetFloorsCount();
    public IEnumerable<Room> GetAllRoomsOnFloor(int floorNumber);
    public void SetRoomGender(string data);
}