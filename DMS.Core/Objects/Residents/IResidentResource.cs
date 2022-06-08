namespace DMS.Core.Objects.Residents;

public interface IResidentResource
{
    Resident GetResidentById(int id);
    Resident GetResidentById(int id, DateTime documentsDate);
    IEnumerable<Resident> GetAllResidents();
    IEnumerable<Resident> GetAllResidents(DateTime documentsDate);
    IEnumerable<Resident> GetAllResidents(string gender, DateTime documentsDate);
    bool IsExists(int id);
    void CreateResident(Resident resident);
    void UpdateResident(Resident resident);
    void DeleteResident(int id);

}