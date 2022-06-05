namespace DMS.Core.Objects.Rooms;

public interface IRoomResource
{
    public Room GetRoomWithResidents(int id, DateTime documentsDate);
    public IEnumerable<int> GetFloorsCount();
    public IEnumerable<Room> GetAllRoomsOnFloor(int floorNumber);
    public void SetRoomGender(string data);
}