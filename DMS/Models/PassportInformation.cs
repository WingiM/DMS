using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DMS.Models;

[Index("SeriesAndNumber", IsUnique = true)]
[Table("resident")]
public class PassportInformation
{
    [Column("passport_information_id")]
    public int PassportInformationId { get; set; }
    
    [Column("series_number", TypeName = "varchar(10)")] 
    public string? SeriesAndNumber { get; set; }
    
    [Column("issued_by", TypeName = "varchar(50)")] 
    public string? IssuedBy { get; set; }  
    
    [Column("department_code")] 
    public int? DepartmentCode { get; set; }
    
    [Column("issue_date")] 
    public DateTime? IssueDate { get; set; }
    
    [Column("address", TypeName = "varchar(70)")] 
    public string? Address { get; set; }

    [Column("resident_id", TypeName = "int")]
    [Required]
    public int ResidentId { get; set; }
    
    public Resident? Resident { get; set; }
}