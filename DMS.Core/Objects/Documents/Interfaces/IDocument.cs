using DMS.Core.Objects.Residents;

namespace DMS.Core.Objects.Documents.Interfaces;

public interface IDocument
{
    public DateTime PostDate { get; set; }
    public Resident Resident { get; set; }
}