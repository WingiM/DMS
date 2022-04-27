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

    public Room? GetById(int id)
    {
        return _context.Rooms
            .Include(r => r.Residents)
            .FirstOrDefault(r => r.RoomId == id);
    }

    public IEnumerable<Room> GetByFloorNumber(int roomNumber)
    {
        return _context.Rooms.Where(r => r.FloorNumber == roomNumber);
    }

    public IEnumerable<Room> GetAll()
    {
        return _context.Rooms;
    }
}