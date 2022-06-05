using DMS.Core.Objects.Residents;
using DMS.Core.Objects.ServiceInterfaces;

namespace DMS.Core.Services;

public class ResidentService : IResidentService
{
    private IResidentResource _residentResource;
    private IDataContext _dataContext;

    public ResidentService(IResidentResource residentResource, IDataContext dataContext)
    {
        _residentResource = residentResource;
        _dataContext = dataContext;
    }

    public IEnumerable<Resident> GetAllResidents()
    {
        return _residentResource.GetAllResidents();
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
        throw new NotImplementedException();
    }

    public int AddResident(string data)
    {
        throw new NotImplementedException();
    }

    public void UpdateResident(int id, string data)
    {
        throw new NotImplementedException();
    }

    public void DeleteResident(int id)
    {
        throw new NotImplementedException();
    }
}