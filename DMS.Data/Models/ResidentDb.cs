using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DMS.Data.Models;

[Index("Tin", IsUnique = true)]
[Table("resident")]
public class ResidentDb
{
    [Key]
    [Column("resident_id", TypeName = "int")] [Required] 
    public int ResidentId { get; set; }

    [Column("last_name", TypeName = "varchar(50)")]
    [Required]
    public string LastName { get; set; }

    [Column("first_name", TypeName = "varchar(30)")]
    [Required]
    public string FirstName { get; set; }

    [Column("patronymic", TypeName = "varchar(30)")]
    public string? Patronymic { get; set; }

    [Column("gender")] 
    [Required]
    public char Gender { get; set; }

    [Column("birth_date")]
    [Required]
    public DateTime BirthDate { get; set; }

    [Column("tin", TypeName = "varchar(12)")]
    public string? Tin { get; set; }
    
    [Column("course")]
    public int? Course { get; set; }

    [Column("is_commercial", TypeName = "bool")]
    public bool IsCommercial { get; set; }
    
    [Column("room_number")]
    public int? RoomId { get; set; }
    public RoomDb? Room { get; set; }

    public PassportInformationDb PassportInformation { get; set; }
    
    public List<RatingOperationDb> RatingOperations { get; set; } = new();
    public List<SettlementOrderDb> SettlementOrders { get; set; } = new();
    public List<EvictionOrderDb> EvictionOrders { get; set; } = new();
    public List<TransactionDb> Transactions { get; set; } = new();

    public int CountRating()
    {
        return RatingOperations.Sum(r => r.ChangeValue);
    }

    public int CountReports()
    {
        return RatingOperations.Count(ro => ro.CategoryId == 1);
    }

    public double CountDebt()
    {
        return Transactions.Sum(t => t.Sum);
    }

    public ResidentDb()
    {
    }

    public ResidentDb(string lastName, string firstName, string? patronymic,
        char gender, DateTime birthDate)
    {
        LastName = lastName;
        FirstName = firstName;
        Patronymic = patronymic;
        Gender = gender;
        BirthDate = birthDate;
    }

    public override string ToString()
    {
        return $"{ResidentId} {LastName} {FirstName}";
    }
}