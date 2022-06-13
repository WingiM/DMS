namespace DMS.Core.Objects.Residents;

public interface IResidentResource
{
    Resident GetResidentById(int id);
    Resident GetResidentById(int id, DateTime documentsDate);
    IEnumerable<Resident> GetAllResidents();
    IEnumerable<Resident> GetAllResidents(DateTime documentsDate);
    IEnumerable<Resident> GetAllResidents(DateTime documentsDate, string gender);
    IEnumerable<Resident> GetAllResidents(string gender);
    bool IsExists(int id);
    int CreateResident(Resident resident);
    void UpdateResident(Resident resident);
    void DeleteResident(int id);

}