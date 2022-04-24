using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models;

public class Room
{
    [Column("room_number", TypeName = "varchar(10)")]
    [Required]
    public string RoomId { get; set; }
        
    [Column("capacity")]
    public int Capacity { get; set; }
        
    [Column("gender")]
    public char Gender { get; set; }

    [Column("floor_number", TypeName = "varchar(1)")] 
    public string FloorNumber { get; set; }

    public List<Resident> Residents { get; set; } = new();

    public Room()
    {
    }
}