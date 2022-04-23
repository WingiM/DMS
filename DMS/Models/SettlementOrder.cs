using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models
{
    public class SettlementOrder
    {
        [Column("operation_id")]
        internal int OperationId { get; private set; }
        
        [Column("resident_id")]
        internal int ResidentId { get; private set; }
        
        [Column("room_number")]
        internal int RoomNumber { get; private set; }
        
        [Column("order_date")]
        internal DateTime OrderDate { get; private set; }
        
        [Column("description")]
        internal string Description { get; private set; }

        public SettlementOrder(int operationId, int residentId, int roomNumber, DateTime orderDate, string description)
        {
            OperationId = operationId;
            ResidentId = residentId;
            RoomNumber = roomNumber;
            OrderDate = orderDate;
            Description = description;
        }
    }
}