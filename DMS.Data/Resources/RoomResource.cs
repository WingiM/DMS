using DMS.Core.Exceptions;
using DMS.Core.Objects.Rooms;
using Microsoft.EntityFrameworkCore;

namespace DMS.Data.Resources;

public class RoomResource : ResourceBase, IRoomResource
{
    public RoomResource(ApplicationContext context) : base(context)
    {
    }

    public Room GetRoom(int roomNumber)
    {
        return GetRoom(roomNumber, DateTime.MinValue);
    }

    public Room GetRoom(int roomNumber, DateTime documentsDate)
    {
        var room = Context.Rooms.FirstOrDefault(r => r.RoomId == roomNumber) ?? throw new DataException("Room not found");
        var roomResidents =
            Context.Residents.Where(r => r.RoomId == roomNumber);
        roomResidents.Load();
        foreach (var resident in roomResidents.ToArray())
        {
            Context.Transactions
                .Where(t => t.ResidentId == resident.ResidentId
                            && t.OperationDate > documentsDate).Load();
            Context.RatingOperations
                .Where(t => t.ResidentId == resident.ResidentId
                            && t.OrderDate > documentsDate).Load();
            Context.RatingChangeCategories.Load();
            Context.Passports.Load();
        }

        return ConvertRoomWithResidents(room);
    }

    public bool IsExists(int roomNumber)
    {
        return Context.Rooms.FirstOrDefault(r => r.RoomId == roomNumber) is not
            null;
    }

    public IEnumerable<int> GetFloorsCount()
    {
        return Context.Rooms.Select(r => r.FloorNumber).Distinct();
    }

    public IEnumerable<Room> GetAllRoomsOnFloor(int floorNumber)
    {
        Context.Residents.Load();
        return Context.Rooms
            .Where(r => r.FloorNumber == floorNumber)
            .AsEnumerable()
            .Select(ConvertRoom);
    }

    public void UpdateRoom(Room room)
    {
        var entity = Context.Rooms.FirstOrDefault(r => r.RoomId == room.Id) ?? throw new DataException("Room not found");

        entity.Gender = room.Gender;
    }
}