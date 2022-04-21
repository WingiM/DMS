using System;
using System.Collections.Generic;

namespace DMS_Main
{
    public class RatingOperation
    {
        public int OperationId { get; set; }
        public int ResidentId { get; set; }
        public int CategoryId { get; set; }
        public int ChangeValue { get; set; }
        public DateOnly OrderDate { get; set; }
        public string Description { get; set; }

        public virtual RatingChangeCategory Category { get; set; }
        public virtual Resident Resident { get; set; }
    }
}
