using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models;

[Table("eviction_order")]
public class EvictionOrder
{
    [Column("order_id")] [Required] public int EvictionOrderId { get; set; }

    [Column("resident_id")] [Required] public int ResidentId { get; set; }

    public Resident? Resident { get; set; }

    [Column("order_date")] [Required] public DateTime OrderDate { get; set; }

    [Column("description", TypeName = "varchar(200)")]
    public string? Description { get; set; }

    public EvictionOrder()
    {
    }
}