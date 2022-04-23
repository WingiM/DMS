namespace DMS.Models
{
    public class EvictionOrder
    {
        internal int order_id { get; private set; }
        internal int resident_id { get; private set; }
        internal string description { get; private set; }

        public EvictionOrder(int orderId, int residentId, string description)
        {
            order_id = orderId;
            resident_id = residentId;
            this.description = description;
        }
    }
}