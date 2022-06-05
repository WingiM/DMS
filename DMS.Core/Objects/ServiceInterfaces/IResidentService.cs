using DMS.Core.Objects.Residents;

namespace DMS.Core.Objects.ServiceInterfaces;

public interface IResidentService
{
    public IEnumerable<Resident> GetAllResidents();
    public Resident GetResidentById(int id);
    public Resident GetResidentById(int id, DateTime documentsStartDate);
    public void AccrualAll(int commercialCost, int nonCommercialCost);
    public void ResetAll();
    public int AddResident(string data);
    public void UpdateResident(int id, string data);
    public void DeleteResident(int id);
}