using System;
using System.Collections.Generic;

namespace DMS_Main
{
    public class Resident
    {
        public Resident()
        {
            EvictionOrders = new HashSet<EvictionOrder>();
            RatingOperations = new HashSet<RatingOperation>();
            SettlementOrders = new HashSet<SettlementOrder>();
            Transactions = new HashSet<Transaction>();
        }

        public int ResidentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public char Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        public string PassportInformation { get; set; }
        public string Tin { get; set; }
        public string RoomNumber { get; set; }

        public override string ToString()
        {
            return $"{ResidentId}: {LastName} {FirstName}";
        }

        public virtual Room RoomNumberNavigation { get; set; }
        public virtual ICollection<EvictionOrder> EvictionOrders { get; set; }
        public virtual ICollection<RatingOperation> RatingOperations { get; set; }
        public virtual ICollection<SettlementOrder> SettlementOrders { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
