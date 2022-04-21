using System;
using System.Collections.Generic;

namespace DMS_Main
{
    public class EvictionOrder
    {
        public int OrderId { get; set; }
        public int? ResidentId { get; set; }
        public string Description { get; set; }

        public virtual Resident Resident { get; set; }
    }
}
