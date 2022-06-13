using DMS.Core.Objects.Documents.Interfaces;
using DMS.Core.Objects.Residents;

namespace DMS.Core.Objects.Documents;

public class EvictionOrder : IOrder
{
    public int Id { get; set; }
    public DateTime PostDate { get; set; }
    public Resident Resident { get; set; }
    public string? Description { get; set; }
}