using System;

namespace DMS.Models
{
    public class RatingOperation
    {
        internal int operation_id { get; private set; }
        internal int resident_id { get; private set; }
        internal int category_id { get; private set; }
        internal int change_value { get; private set; }
        internal DateTime order_date { get; private set; }
        internal string description { get; private set; }

        public RatingOperation(int operationId, int residentId, int categoryId, int changeValue, DateTime orderDate, string description)
        {
            operation_id = operationId;
            resident_id = residentId;
            category_id = categoryId;
            change_value = changeValue;
            order_date = orderDate;
            this.description = description;
        }
    }
}