using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DMS.Models;

[Index("Tin", IsUnique = true)]
[Table("resident")]
public class Resident
{
    [Column("resident_id")] [Required] 
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

    [Column("is_commercial", TypeName = "bool")]
    public bool IsCommercial { get; set; }
    
    [Column("room_number")]
    public int? RoomId { get; set; }
    public Room? Room { get; set; }

    public PassportInformation? PassportInformation { get; set; }
    
    public List<RatingOperation> RatingOperations { get; set; } = new();
    public List<SettlementOrder> SettlementOrders { get; set; } = new();
    public List<EvictionOrder> EvictionOrders { get; set; } = new();
    public List<Transaction> Transactions { get; set; } = new();

    internal int CountRating()
    {
        return RatingOperations.Sum(r => r.ChangeValue);
    }

    internal int CountReports()
    {
        return RatingOperations.Count(ro => ro.CategoryId == 1);
    }

    internal double CountDebt()
    {
        return Transactions.Sum(t => t.Sum);
    }

    public Resident()
    {
    }

    public Resident(string lastName, string firstName, string? patronymic,
        char gender, DateTime birthDate)
    {
        LastName = lastName;
        FirstName = firstName;
        Patronymic = patronymic;
        Gender = gender;
        BirthDate = birthDate;
    }

    public void FillDocuments(string? passportInfo, string? TIN)
    {
        //PassportInformation = passportInfo;
        this.Tin = TIN;
    }

    public override string ToString()
    {
        return $"{ResidentId} {LastName} {FirstName}";
    }
}