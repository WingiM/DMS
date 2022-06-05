using DMS.Core.Objects.Documents;
using DMS.Core.Objects.Rooms;

namespace DMS.Core.Objects.Residents;

public class Resident
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string? Patronymic { get; set; }
    public char Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string? Tin { get; set; }
    public int? Course { get; set; }
    public bool IsCommercial { get; set; }
    public Room? Room { get; set; }
    public PassportInformation PassportInformation { get; set; }
    public int Rating { get; set; }
    public double Balance { get; set; }
    public int Reports { get; set; }

    public List<SettlementOrder> SettlementOrders { get; set; } = new();
    public List<EvictionOrder> EvictionOrders { get; set; } = new();
    public List<Transaction> Transactions { get; set; } = new();
    public List<RatingOperation> RatingOperations { get; set; } = new();
}