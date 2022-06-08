namespace DMS.Core.Objects.Documents;

public class ParentData
{
    public string? ParentsFullName { get; set; }
    public string? ParentsPassportSeriesNumber { get; set; }
    public string? ParentsPassportIssuedBy { get; set; }
    public int? ParentsPassportDepartmentCode { get; set; }
    public DateTime? ParentsPassportIssueDate { get; set; }
    public string? ParentsPassportAddress { get; set; }
}