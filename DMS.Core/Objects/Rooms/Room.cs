using DMS.Core.Objects.Residents;

namespace DMS.Core.Objects.Rooms;

public class Room
{
    public int Id { get; set; }
    public int Capacity { get; set; }
    public char Gender { get; set; }
    public int FloorNumber { get; set; }
    public bool IsFull { get; set; }
    public List<Resident> Residents { get; set; } = new();
}