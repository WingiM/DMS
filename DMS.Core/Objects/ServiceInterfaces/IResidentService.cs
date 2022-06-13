using DMS.Core.Objects.Residents;

namespace DMS.Core.Objects.ServiceInterfaces;

public interface IResidentService
{
    public IEnumerable<Resident> GetAllResidents();

    public IEnumerable<Resident> GetAllResidents(DateTime documentsStartDate,
        string gender);

    public IEnumerable<Resident> GetAllResidents(string gender);
    public IEnumerable<Resident> GetAllResidents(DateTime documentsStartDate);
    public Resident GetResidentById(int id);
    public Resident GetResidentById(int id, DateTime documentsStartDate);

    public int CreateResident(string lastName, string firstName, char gender,
        DateTime birthDate, PassportInformation passportInformation,
        bool isCommercial, string? tin = null, int? course = null,
        string? patronymic = null);

    public void UpdateResident(int id, string lastName, string firstName,
        char gender, DateTime birthDate,
        PassportInformation passportInformation, bool isCommercial,
        string? tin = null, int? course = null, string? patronymic = null);

    public void DeleteResident(int id);
}