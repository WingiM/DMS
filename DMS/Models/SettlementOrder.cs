using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models;

public class SettlementOrder
{
    [Column("order_id")]
    [Required]
    public int SettlementOrderId { get; set; }
    
    [Column("resident_id")]
    [Required]
    public int ResidentId { get; set; }
    public Resident? Resident { get; set; }
    
    [Required]
    [Column("room_number")]
    public int RoomNumber { get; set; }
    public Room? Room { get; set; }
        
    [Column("order_date")]
    [Required]
    public DateTime OrderDate { get; set; }
        
    [Column("description", TypeName = "varchar(200)")]
    public string? Description { get; set; }

    public SettlementOrder()
    {
    }
}