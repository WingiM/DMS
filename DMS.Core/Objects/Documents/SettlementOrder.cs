using DMS.Core.Objects.Documents.Interfaces;
using DMS.Core.Objects.Residents;
using DMS.Core.Objects.Rooms;

namespace DMS.Core.Objects.Documents;

public class SettlementOrder : IDocument
{
    public int Id { get; set; }
    public DateTime PostDate { get; set; }
    public Resident Resident { get; set; }
    public Room Room { get; set; }
    public string? Description { get; set; }
    public string? ParentsFullName { get; set; }
    public string? ParentsPassportSeriesNumber { get; set; }
    public string? ParentsPassportIssuedBy { get; set; }
    public int? ParentsPassportDepartmentCode { get; set; }
    public DateTime? ParentsPassportIssueDate { get; set; }
    public string? ParentsPassportAddress { get; set; }
}