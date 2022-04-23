using System;

namespace DMS.Models
{
    public class SettlementOrder
    {
        internal int operation_id { get; private set; }
        internal int resident_id { get; private set; }
        internal int room_number { get; private set; }
        internal DateTime order_date { get; private set; }
        internal string description { get; private set; }

        public SettlementOrder(int operationId, int residentId, int roomNumber, DateTime orderDate, string description)
        {
            operation_id = operationId;
            resident_id = residentId;
            room_number = roomNumber;
            order_date = orderDate;
            this.description = description;
        }
    }
}