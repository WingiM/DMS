using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Data.Models;

[Table("eviction_order")]
public class EvictionOrderDb
{
    [Key] [Required] public int EvictionOrderId { get; set; }

    [Required] public int ResidentId { get; set; }

    public ResidentDb Resident { get; set; }

    [Required] public DateTime OrderDate { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string? Description { get; set; }

    public EvictionOrderDb()
    {
    }
}