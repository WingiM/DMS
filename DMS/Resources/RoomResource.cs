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

    public Room? GetRoomById(int id)
    {
        return _context.Rooms
            .Include(r => r.Residents)
            .FirstOrDefault(r => r.RoomId == id);
    }

    public IEnumerable<int> GetFloorsCount()
    {
        return _context.Rooms.Select(r => r.FloorNumber).Distinct();
    }

    public IEnumerable<Room> GetAllRoomsOnFloor(int roomNumber)
    {
        return _context.Rooms.Where(r => r.FloorNumber == roomNumber);
    }

    public IEnumerable<Room> GetAllRooms()
    {
        return _context.Rooms;
    }
}