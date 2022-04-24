using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models;

public class RatingOperation
{
    [Column("operation_id")]
    [Required]
    public int RatingOperationId { get; set; }
        
    [Column("resident_id")]
    [Required]
    public Resident? ResidentId { get; set; }
        
    [Column("category_id")]
    public RatingChangeCategory? CategoryId { get; set; }
        
    [Column("change_value")]
    public int ChangeValue { get; set; }
        
    [Column("order_date")]
    [Required]
    public DateTime OrderDate { get; set; }
        
    [Column("description", TypeName = "varchar(200)")]
    public string Description { get; set; }

    public RatingOperation()
    {
    }
}