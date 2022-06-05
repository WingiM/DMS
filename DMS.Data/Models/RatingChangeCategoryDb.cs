using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Data.Models;

[Table("rating_change_category")]
public class RatingChangeCategoryDb
{
    [Key]
    [Column(TypeName = "int")]
    [Required]
    public int RatingChangeCategoryId { get; set; }

    [Column("name", TypeName = "varchar(20)")]
    public string Name { get; set; }

    public RatingChangeCategoryDb()
    {
    }
}