namespace DMS.Core.Objects.Rooms;

public interface IRoomResource
{
    public Room GetRoom(int roomNumber);
    public Room GetRoom(int roomNumber, DateTime documentsDate);
    public bool IsExists(int roomNumber);
    public IEnumerable<int> GetFloorsCount();
    public IEnumerable<Room> GetAllRoomsOnFloor(int floorNumber);
    public void UpdateRoom(Room room);
}