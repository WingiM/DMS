using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Data.Models;

[Table("transaction")]
public class TransactionDb
{
    [Key]
    [Column("transaction_id")]
    [Required]
    public int TransactionId { get; set; }
    
    [Column("resident_id")]
    [Required] 
    public int ResidentId { get; set; }

    public ResidentDb? Resident { get; set; }

    [Column("operation_date")]
    [Required]
    public DateTime OperationDate { get; set; }

    [Column("sum")] public double Sum { get; set; }

    public TransactionDb()
    {
    }
}