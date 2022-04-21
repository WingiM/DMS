using System;
using System.Collections.Generic;

namespace DMS_Main
{
    public class Room
    {
        public Room()
        {
            Residents = new HashSet<Resident>();
            SettlementOrders = new HashSet<SettlementOrder>();
        }

        public string RoomNumber { get; set; }
        public short? Capacity { get; set; }
        public char Gender { get; set; }
        public char? FloorNumber { get; set; }

        public virtual ICollection<Resident> Residents { get; set; }
        public virtual ICollection<SettlementOrder> SettlementOrders { get; set; }
    }
}
