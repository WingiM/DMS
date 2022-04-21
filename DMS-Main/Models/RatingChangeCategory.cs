using System;
using System.Collections.Generic;

namespace DMS_Main
{
    public class RatingChangeCategory
    {
        public RatingChangeCategory()
        {
            RatingOperations = new HashSet<RatingOperation>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RatingOperation> RatingOperations { get; set; }
    }
}
