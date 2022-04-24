using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models;

public class SettlementOrder
{
    [Column("order_id")]
    [Required]
    public int SettlementOrderId { get; set; }
    
    [Required]
    public Resident? Resident { get; set; }
    
    [Required]
    public Room? RoomNumber { get; set; }
        
    [Column("order_date")]
    [Required]
    public DateTime OrderDate { get; set; }
        
    [Column("description", TypeName = "varchar(200)")]
    public string Description { get; set; }

    public SettlementOrder()
    {
    }
}