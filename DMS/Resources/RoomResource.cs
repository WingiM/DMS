using System.Text.Json;
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
        _context.Residents.Load();
        return _context.Rooms.Where(r => r.FloorNumber == roomNumber);
    }

    public Tuple<bool, string?> SetRoomGender(string data)
    {
        try
        {
            var deserialized =
                JsonSerializer.Deserialize<Dictionary<string, string>>(data);
            if (!int.TryParse(deserialized["RoomId"], out var res))
                return new Tuple<bool, string?>(false, "Wrong room id value");

            if (!char.TryParse(deserialized["Gender"], out var gender))
                return new Tuple<bool, string?>(false, "Wrong gender value");

            var room = _context.Rooms.FirstOrDefault(r => r.RoomId == res);

            if (room is null)
                return new Tuple<bool, string?>(false, "No room with such number");

            room.Gender = gender;
            _context.SaveChanges();
            return new Tuple<bool, string?>(true, null);
        }
        catch (KeyNotFoundException)
        {
            return new Tuple<bool, string?>(false, "Wrong body format");
        }
        catch (NullReferenceException)
        {
            return new Tuple<bool, string?>(false, "Could not parse body");
        }
    }
}