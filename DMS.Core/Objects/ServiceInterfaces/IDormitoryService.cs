using DMS.Core.Objects.Dormitory;
using DMS.Core.Objects.Residents;

namespace DMS.Core.Objects.ServiceInterfaces;

public interface IDormitoryService
{
    public DormitorySettlementData GetDormitorySettlementData();
    public Dictionary<string, string> GetConstants();

    public void SetPriceConstants(int commercialCost = 0,
        int nonCommercialCost = 0);

    public void SetResetConstants(int floors, int roomsCount, int roomCapacity);
    public IEnumerable<Resident> GetResettlementList();
    public void AccrualAllResidents();
    public void RebuildDormitoryRooms();
}