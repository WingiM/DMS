using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DMS.Data.Models;

[Index("SeriesAndNumber", IsUnique = true)]
[Table("passport_information")]
public class PassportInformationDb
{
    
    [Key] public int PassportInformationId { get; set; }
    
    [Column(TypeName = "varchar(10)")] 
    public string? SeriesAndNumber { get; set; }
    
    [Column(TypeName = "varchar(50)")] 
    public string? IssuedBy { get; set; }  
    
    public int? DepartmentCode { get; set; }
    
    [Column("issue_date")] 
    public DateTime? IssueDate { get; set; }
    
    [Column(TypeName = "varchar(70)")] 
    public string? Address { get; set; }

    [Column(TypeName = "int")]
    [Required]
    public int ResidentId { get; set; }
    
    [JsonIgnore]
    public ResidentDb Resident { get; set; }
}