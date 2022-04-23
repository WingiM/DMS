using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models
{
    public class EvictionOrder
    {
        [Column("order_id")]
        internal int OrderId { get; private set; }
        
        [Column("resident_id")]
        internal int ResidentId { get; private set; }
        
        [Column("description")]
        internal string Description { get; private set; }

        public EvictionOrder(int orderId, int residentId, string description)
        {
            OrderId = orderId;
            ResidentId = residentId;
            Description = description;
        }
    }
}