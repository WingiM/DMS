namespace DMS.Core.Objects.Dormitory;

public interface IDormitoryResource
{
    public DormitorySettlementData GetDormitoryData();
    public string GetConstant(string key);
    public void SetConstant(string key, string value);
    public void SetResetConstants(ResetConstants resetConstants);
    public Dictionary<string, string> GetConstants();
    public void ResetDormitoryRooms();
}