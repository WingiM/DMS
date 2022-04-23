using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models
{
    public class RatingChangeCategory
    {
        [Column("category_id")]
        internal int CategoryId { get; private set; }
        
        [Column("name")]
        internal string Name { get; private set; }

        public RatingChangeCategory(int categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }
    }
}