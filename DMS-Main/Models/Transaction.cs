using System;
using System.Collections.Generic;

namespace DMS_Main
{
    public class Transaction
    {
        public int OperationId { get; set; }
        public int ResidentId { get; set; }
        public int Sum { get; set; }

        public virtual Resident Resident { get; set; }
    }
}
