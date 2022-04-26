using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models;

[Table("rating_operation")]
public class RatingOperation
{
    [Column("operation_id")] [Required] public int RatingOperationId { get; set; }

    [Column("resident_id")] [Required] public int ResidentId { get; set; }

    public Resident? Resident { get; set; }

    [Column("change_value")] public int ChangeValue { get; set; }

    [Column("order_date")] [Required] public DateTime OrderDate { get; set; }

    [Column("description", TypeName = "varchar(200)")]
    public string? Description { get; set; }

    [Column("category_id")] public int CategoryId { get; set; }
   
    public RatingChangeCategory? Category { get; set; }

    public RatingOperation()
    {
    }
}