using System.ComponentModel.DataAnnotations.Schema;

namespace DataManipulation
{
    public class Transactions
    {
        [Column("operation_id")]
        internal int OperationId { get; private set; }
        
        [Column("resident_id")]
        internal int ResidentId { get; private set; }
        
        [Column("sum")]
        internal double Sum { get; private set; }

        public Transactions(int operationId, int residentId, double sum)
        {
            OperationId = operationId;
            ResidentId = residentId;
            Sum = sum;
        }
    }
}