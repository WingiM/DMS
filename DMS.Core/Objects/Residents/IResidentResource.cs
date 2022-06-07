namespace DMS.Core.Objects.Residents;

public interface IResidentResource
{
    public IEnumerable<Resident> GetAllResidents();
    public IEnumerable<Resident> GetAllResidents(DateTime documentsStartDate,
        string gender);
    public Resident GetResidentById(int id);
    public Resident GetResidentById(int id, DateTime documentsStartDate);
    public void AccrualAll(int commercialCost, int nonCommercialCost);
    public void ResetAll();
    public int AddResident(string data);
    public void UpdateResident(int id, string data);
    public void DeleteResident(int id);
}