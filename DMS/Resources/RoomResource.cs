using DMS.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS.Resources;

public class RoomResource
{
    private readonly ApplicationContext _context;

    public RoomResource(ApplicationContext context)
    {
        _context = context;
    }

    public Room? GetRoomWithResidents(int id, DateTime documentDate)
    {
        var room = _context.Rooms.FirstOrDefault(r => r.RoomId == id);
        var roomResidents = _context.Residents.Where(r => r.RoomId == id);
        roomResidents.Load();
        foreach (var resident in roomResidents.ToArray())
        {
            _context.Transactions
                .Where(t => t.ResidentId == resident.ResidentId
                            && t.OperationDate > documentDate).Load();
            _context.RatingOperations
                .Where(t => t.ResidentId == resident.ResidentId
                            && t.OrderDate > documentDate).Load();
            _context.RatingChangeCategories.Load();
            _context.Passports.Load();
        }

        return room;
    }

    public IEnumerable<int> GetFloorsCount()
    {
        return _context.Rooms.Select(r => r.FloorNumber).Distinct();
    }

    public IEnumerable<Room> GetAllRoomsOnFloor(int roomNumber)
    {
        return _context.Rooms.Where(r => r.FloorNumber == roomNumber);
    }
}