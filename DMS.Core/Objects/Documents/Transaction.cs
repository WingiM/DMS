using DMS.Core.Objects.Documents.Interfaces;
using DMS.Core.Objects.Residents;

namespace DMS.Core.Objects.Documents;

public class Transaction : IDocument
{
    public int Id { get; set; }
    public DateTime PostDate { get; set; }
    public Resident Resident { get; set; }
    public double Sum { get; set; }
}