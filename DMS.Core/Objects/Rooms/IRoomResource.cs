namespace DMS.Core.Objects.Rooms;

public interface IRoomResource
{
    public Room GetRoom(int id);
    public Room GetRoom(int id, DateTime documentsDate);
    public bool IsExists(int roomNumber);
    public IEnumerable<int> GetFloorsCount();
    public IEnumerable<Room> GetAllRoomsOnFloor(int floorNumber);
    public void UpdateRoom(Room room);
}