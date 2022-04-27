using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models;

[Table("room")]
public class Room
{
    [Column("room_number", TypeName = "int")]
    [Required]
    public int RoomId { get; set; }

    [Column("capacity")] public int Capacity { get; set; }

    [Column("gender")] public char Gender { get; set; }

    [Column("floor_number")]
    public int FloorNumber { get; set; }

    public List<Resident> Residents { get; set; } = new();

    public Room()
    {
    }
}