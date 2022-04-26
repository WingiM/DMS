using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DMS.Models;

[Index("PassportInformation", IsUnique = true)]
[Index("Tin", IsUnique = true)]
[Table("resident")]
public class Resident
{
    [Column("resident_id")] [Required] public int ResidentId { get; set; }

    [Column("last_name", TypeName = "varchar(50)")]
    [Required]
    public string LastName { get; set; }

    [Column("first_name", TypeName = "varchar(30)")]
    [Required]
    public string FirstName { get; set; }

    [Column("patronymic", TypeName = "varchar(30)")]
    public string? Patronymic { get; set; }

    [Column("gender")] [Required] public char Gender { get; set; }

    [Column("birth_date")] [Required] public DateTime BirthDate { get; set; }

    [Column("passport_information", TypeName = "varchar(10)")]
    public string? PassportInformation { get; set; }

    [Column("tin", TypeName = "varchar(12)")]
    public string? Tin { get; set; }


    [Column("room_number")] public int RoomId { get; set; }
    public Room? Room { get; set; }

    public List<RatingOperation> RatingOperations { get; set; } = new();
    public List<SettlementOrder> SettlementOrders { get; set; } = new();
    public List<EvictionOrder> EvictionOrders { get; set; } = new();

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
        PassportInformation = passportInfo;
        this.Tin = TIN;
    }

    public override string ToString()
    {
        return $"{ResidentId} {LastName} {FirstName}";
    }
}