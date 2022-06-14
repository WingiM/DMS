using DMS.Core.Objects.Documents.Interfaces;
using DMS.Core.Objects.ServiceInterfaces;

namespace DMS.Core.Objects.Residents;

public class ResidentService : IResidentService
{
    private readonly IResidentResource _residentResource;
    private readonly IDocumentsResource _documentsResource;
    private readonly IDataContext _dataContext;

    public ResidentService(IResidentResource residentResource,
        IDataContext dataContext, IDocumentsResource documentsResource)
    {
        _residentResource = residentResource;
        _dataContext = dataContext;
        _documentsResource = documentsResource;
    }

    public IEnumerable<Resident> GetAllResidents()
    {
        return _residentResource.GetAllResidents();
    }

    public IEnumerable<Resident> GetAllResidents(DateTime documentsStartDate,
        string gender)
    {
        return _residentResource.GetAllResidents(documentsStartDate, gender);
    }

    public IEnumerable<Resident> GetAllResidents(string gender)
    {
        return _residentResource.GetAllResidents(gender);
    }
    
    public IEnumerable<Resident> GetAllResidents(DateTime documentsStartDate)
    {
        return _residentResource.GetAllResidents(documentsStartDate);
    }

    public Resident GetResidentById(int id)
    {
        return _residentResource.GetResidentById(id);
    }

    public Resident GetResidentById(int id, DateTime documentsStartDate)
    {
        return _residentResource.GetResidentById(id, documentsStartDate);
    }

    public int CreateResident(string lastName, string firstName, char gender,
        DateTime birthDate, PassportInformation passportInformation,
        bool isCommercial, string? tin = null, int? course = null,
        string? patronymic = null)
    {
        var resident = new Resident
        {
            LastName = lastName, FirstName = firstName, Patronymic = patronymic,
            BirthDate = birthDate, PassportInformation = passportInformation,
            IsCommercial = isCommercial, Tin = tin, Course = course,
            Gender = gender
        };

        return _residentResource.CreateResident(resident);
    }

    public void UpdateResident(int id, string lastName, string firstName,
        char gender, DateTime birthDate,
        PassportInformation passportInformation, bool isCommercial,
        string? tin = null, int? course = null, string? patronymic = null)
    {
        var resident = new Resident
        {
            Id = id, LastName = lastName, FirstName = firstName,
            Patronymic = patronymic, BirthDate = birthDate,
            PassportInformation = passportInformation,
            IsCommercial = isCommercial, Tin = tin, Course = course,
            Gender = gender
        };

        _residentResource.UpdateResident(resident);
        _dataContext.SaveChanges();
    }

    public void DeleteResident(int id)
    {
        _residentResource.DeleteResident(id);
        _dataContext.SaveChanges();
    }
}