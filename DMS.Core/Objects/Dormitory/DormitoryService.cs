using DMS.Core.Objects.Documents;
using DMS.Core.Objects.Documents.Interfaces;
using DMS.Core.Objects.Residents;
using DMS.Core.Objects.ServiceInterfaces;

namespace DMS.Core.Objects.Dormitory;

public class DormitoryService : IDormitoryService
{
    private readonly IDormitoryResource _dormitoryResource;
    private readonly IResidentResource _residentResource;
    private readonly IDocumentsResource _documentsResource;
    private readonly IDataContext _dataContext;

    public DormitoryService(IDormitoryResource dormitoryResource,
        IResidentResource residentResource,
        IDocumentsResource documentsResource, IDataContext dataContext)
    {
        _dormitoryResource = dormitoryResource;
        _residentResource = residentResource;
        _documentsResource = documentsResource;
        _dataContext = dataContext;
    }

    public DormitorySettlementData GetDormitorySettlementData()
    {
        return _dormitoryResource.GetDormitoryData();
    }

    public Dictionary<string, string> GetConstants()
    {
        return _dormitoryResource.GetPriceConstants()
            .Concat(_dormitoryResource.GetResetConstants())
            .ToDictionary(pair => pair.Key, pair => pair.Value.ToString());
    }

    public void SetPriceConstants(int commercialCost = 0,
        int nonCommercialCost = 0)
    {
        _dormitoryResource.SetConstants(new PriceConstants(commercialCost,
            nonCommercialCost));
    }

    public void SetResetConstants(int floors, int roomsCount, int roomCapacity)
    {
        _dormitoryResource.SetConstants(new ResetConstants(floors, roomsCount, roomCapacity));
    }

    public IEnumerable<Resident> GetResettlementList()
    {
        var residents = _residentResource.GetAllResidents().ToList();

        var firstCourses = residents
            .Where(r => r.Course == 1)
            .OrderBy(r => r.LastName);

        var others = residents
            .Where(r => r.Course != 1)
            .OrderByDescending(r => r.Rating)
            .ThenBy(r => r.LastName);

        return firstCourses.Concat(others);
    }


    public void AccrualAllResidents()
    {
        var constants = _dormitoryResource.GetPriceConstants();
        foreach (var resident in _residentResource.GetAllResidents())
        {
            if (resident.Room is null)
                continue;

            var transaction = new Transaction
            {
                PostDate = DateTime.Now, Resident = resident,
                Sum = resident.IsCommercial
                    ? constants["commercialCost"]
                    : constants["nonCommercialCost"]
            };
            _documentsResource.AddDocument(transaction);
        }

        _dataContext.SaveChanges();
    }

    private void ResetAllResidents()
    {
        foreach (var resident in _residentResource.GetAllResidents())
        {
            if (resident.Room is null)
                continue;

            var evictionOrder = new EvictionOrder
            {
                PostDate = DateTime.Now, Description = "Dormitory reset",
                Resident = resident
            };

            _documentsResource.AddDocument(evictionOrder);
            resident.Course++;
            _residentResource.UpdateResident(resident);
        }

        _dataContext.SaveChanges();
    }

    public void ResetDormitoryResidentsAndRooms()
    {
        ResetAllResidents();
        _dormitoryResource.ResetDormitoryRooms();

        _dataContext.SaveChanges();
    }
}