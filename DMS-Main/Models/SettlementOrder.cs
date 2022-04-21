using System;
using System.Collections.Generic;

namespace DMS_Main
{
    public class SettlementOrder
    {
        public int OperationId { get; set; }
        public int? ResidentId { get; set; }
        public string RoomNumber { get; set; }
        public DateOnly OrderDate { get; set; }
        public string Description { get; set; }

        public virtual Resident Resident { get; set; }
        public virtual Room RoomNumberNavigation { get; set; }
    }
}
