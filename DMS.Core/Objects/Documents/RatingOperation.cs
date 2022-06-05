using DMS.Core.Objects.Documents.Interfaces;
using DMS.Core.Objects.Residents;

namespace DMS.Core.Objects.Documents;

public class RatingOperation : IDocument
{
    public int Id { get; set; }
    public DateTime PostDate { get; set; }
    public Resident Resident { get; set; }
    public int ChangeValue { get; set; }
    public string? Description { get; set; }
    public RatingChangeCategory Category { get; set; }
}