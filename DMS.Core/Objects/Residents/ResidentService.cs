using DMS.Core.Objects.ServiceInterfaces;

namespace DMS.Core.Objects.Residents;

public class ResidentService : IResidentService
{
    private readonly IResidentResource _residentResource;
    private readonly IDataContext _dataContext;

    public ResidentService(IResidentResource residentResource, IDataContext dataContext)
    {
        _residentResource = residentResource;
        _dataContext = dataContext;
    }

    public IEnumerable<Resident> GetAllResidents()
    {
        return _residentResource.GetAllResidents();
    }

    public IEnumerable<Resident> GetAllResidents(DateTime documentsStartDate, string gender)
    {
        return _residentResource.GetAllResidents(documentsStartDate, gender);
    }

    public Resident GetResidentById(int id)
    {
        return _residentResource.GetResidentById(id);
    }

    public Resident GetResidentById(int id, DateTime documentsStartDate)
    {
        return _residentResource.GetResidentById(id, documentsStartDate);
    }

    public void AccrualAll(int commercialCost, int nonCommercialCost)
    {
        _residentResource.AccrualAll(commercialCost, nonCommercialCost);
        _dataContext.SaveChanges();
    }

    public void ResetAll()
    {
        _residentResource.ResetAll();
    }

    public int AddResident(string data)
    {
        return _residentResource.AddResident(data);
    }

    public void UpdateResident(int id, string data)
    {
        _residentResource.UpdateResident(id, data);
    }

    public void DeleteResident(int id)
    {
        _residentResource.DeleteResident(id);
    }
}