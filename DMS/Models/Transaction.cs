using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models;

public class Transaction
{
    [Column("operation_id")]
    [Required]
    public int TransactionId { get; set; }
        
    [Column("resident_id")]
    [Required]
    public Resident? ResidentId { get; set; }
    
    [Column("operation_date")]
    [Required]
    public DateTime OperationDate { get; set; }
        
    [Column("sum")]
    public double Sum { get; set; }

    public Transaction()
    {
    }
}