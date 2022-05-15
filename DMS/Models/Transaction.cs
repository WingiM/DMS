using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models;

[Table("transaction")]
public class Transaction
{
    [Column("transaction_id")]
    [Required]
    public int TransactionId { get; set; }
    
    [Column("resident_id")]
    [Required] 
    public int ResidentId { get; set; }

    public Resident? Resident { get; set; }

    [Column("operation_date")]
    [Required]
    public DateTime OperationDate { get; set; }

    [Column("sum")] public double Sum { get; set; }

    public Transaction()
    {
    }
}