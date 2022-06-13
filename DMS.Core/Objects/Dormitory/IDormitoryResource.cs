namespace DMS.Core.Objects.Dormitory;

public interface IDormitoryResource
{
    public PriceConstants GetPriceConstants();
    public ResetConstants GetResetConstants();
    public void SetConstants(PriceConstants priceConstants);
    public void SetConstants(ResetConstants resetConstants);
    public DormitorySettlementData GetDormitoryData();
    public void ResetDormitoryRooms();
}