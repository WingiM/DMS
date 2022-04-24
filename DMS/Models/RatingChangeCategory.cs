using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models;

public class RatingChangeCategory
{
    [Column("category_id")]
    [Required]
    public int RatingChangeCategoryId { get; set; }
        
    [Column("name", TypeName = "varchar(20)")]
    public string Name { get; set; }

    public RatingChangeCategory()
    {
    }

    public RatingChangeCategory(string name)
    {
        Name = name;
    }
}