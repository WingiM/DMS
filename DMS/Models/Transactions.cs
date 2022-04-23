namespace DataManipulation
{
    public class Transactions
    {
        internal int operation_id { get; private set; }
        internal int resident_id { get; private set; }
        internal double sum { get; private set; }

        public Transactions(int operationId, int residentId, double sum)
        {
            operation_id = operationId;
            resident_id = residentId;
            this.sum = sum;
        }
    }
}