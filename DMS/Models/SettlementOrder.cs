using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMS.Models;

[Table("settlement_order")]
public class SettlementOrder
{
    [Column("order_id", TypeName = "int")]
    [Required]
    public int SettlementOrderId { get; set; }

    [Column("resident_id")] [Required] public int ResidentId { get; set; }
    public Resident? Resident { get; set; }

    [Column("room_number", TypeName = "int")]
    [Required]
    public int RoomId { get; set; }

    public Room? Room { get; set; }

    [Column("order_date")] [Required] public DateTime OrderDate { get; set; }

    [Column("description", TypeName = "varchar(200)")]
    public string? Description { get; set; }

    [Column("parents_name", TypeName = "varchar(110)")]
    public string? ParentsFullName { get; set; }

    [Column("parents_passport_series_number", TypeName = "varchar(10)")]
    public string? ParentsPassportSeriesNumber { get; set; }

    [Column("parents_passport_issued_by", TypeName = "varchar(50)")]
    public string? ParentsPassportIssuedBy { get; set; }

    [Column("parents_passport_department_code")]
    public int? ParentsPassportDepartmentCode { get; set; }

    [Column("parents_passport_issue_date")]
    public DateTime? ParentsPassportIssueDate { get; set; }

    [Column("parents_passport_address", TypeName = "varchar(70)")]
    public string? ParentsPassportAddress { get; set; }


    public SettlementOrder()
    {
    }
}