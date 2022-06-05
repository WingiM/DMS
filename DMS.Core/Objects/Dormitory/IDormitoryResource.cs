namespace DMS.Core.Objects.Dormitory;

public interface IDormitoryResource
{
    public Dictionary<string, int> GetDormitoryCapacity();
    public string SetSafeConstants(string data);
    public Dictionary<string, string> GetConstants();
    public void SetHardResetConstants(string data);
    public void ResetRooms();
    public string GetConstant(string key);
}