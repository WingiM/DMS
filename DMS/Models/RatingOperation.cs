using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models
{
    public class RatingOperation
    {
        [Column("operation_id")]
        internal int OperationId { get; private set; }
        
        [Column("resident_id")]
        internal int ResidentId { get; private set; }
        
        [Column("category_id")]
        internal int CategoryId { get; private set; }
        
        [Column("change_value")]
        internal int ChangeValue { get; private set; }
        
        [Column("order_date")]
        internal DateTime OrderDate { get; private set; }
        
        [Column("description")]
        internal string Description { get; private set; }

        public RatingOperation(int operationId, int residentId, int categoryId, int changeValue, DateTime orderDate, string description)
        {
            OperationId = operationId;
            ResidentId = residentId;
            CategoryId = categoryId;
            ChangeValue = changeValue;
            OrderDate = orderDate;
            Description = description;
        }
    }
}