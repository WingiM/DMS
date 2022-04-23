namespace DMS.Models
{
    public class RatingChangeCategory
    {
        internal int category_id { get; private set; }
        internal string name { get; private set; }

        public RatingChangeCategory(int categoryId, string name)
        {
            category_id = categoryId;
            this.name = name;
        }
    }
}