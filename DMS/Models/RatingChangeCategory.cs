using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models;

[Table("rating_change_category")]
public class RatingChangeCategory
{
    [Column("category_id")] [Required] public int RatingChangeCategoryId { get; set; }

    [Column("name", TypeName = "varchar(20)")]
    public string Name { get; set; }

    public RatingChangeCategory()
    {
    }
}