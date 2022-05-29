using System.Text.Json;
using DMS.Exceptions;
using DMS.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS.Resources;

public class RoomResource : ResourceBase
{
    private readonly ApplicationContext _context;

    public RoomResource(ApplicationContext context)
    {
        _context = context;
    }

    public Room GetRoomWithResidents(int id, DateTime documentDate)
    {
        try
        {
            var room = _context.Rooms.First(r => r.RoomId == id);
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
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException("No room with this Id", e);
        }
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

    public void SetRoomGender(string data)
    {
        try
        {
            var deserialized =
                JsonSerializer.Deserialize<Dictionary<string, Object>>(data);

            var res = int.Parse(deserialized!["RoomId"].ToString()!);
            if (!char.TryParse(deserialized["Gender"].ToString(),
                    out var gender) || !new[] { 'M', 'F' }.Contains(gender))
                throw new InvalidRequestDataException("Wrong gender value");

            var room = _context.Rooms.First(r => r.RoomId == res);
            room.Gender = gender;
            _context.SaveChanges();
        }
        catch (NullReferenceException e)
        {
            throw new InvalidRequestDataException(
                "Could not deserialize request body", e);
        }
        catch (InvalidCastException e)
        {
            throw new InvalidRequestDataException("Wrong room id value", e);
        }
        catch (InvalidOperationException e)
        {
            throw new Exception("No room with such number", e);
        }
        catch (Exception e)
        {
            throw new Exception(GetExceptionMessage(e), e);
        }
    }
}