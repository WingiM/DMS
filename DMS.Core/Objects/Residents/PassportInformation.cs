namespace DMS.Core.Objects.Residents;

public class PassportInformation
{
    public int Id { get; set; }
    public string? SeriesAndNumber { get; set; }
    public string? IssuedBy { get; set; }
    public int? DepartmentCode { get; set; }
    public DateTime? IssueDate { get; set; }
    public string? Address { get; set; }
}