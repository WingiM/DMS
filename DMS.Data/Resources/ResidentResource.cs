using DMS.Core.Objects.Residents;
using DMS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS.Data.Resources;

public class ResidentResource : ResourceBase, IResidentResource
{
    public ResidentResource(ApplicationContext context) : base(context)
    {
    }

    public Resident GetResidentById(int id)
    {
        return GetResidentById(id, DateTime.MinValue);
    }

    public Resident GetResidentById(int id, DateTime documentsDate)
    {
        Context.Transactions
            .Where(t => t.ResidentId == id && t.OperationDate > documentsDate)
            .Load();
        Context.RatingOperations
            .Where(ro => ro.ResidentId == id && ro.OrderDate > documentsDate)
            .Load();
        Context.Passports.Load();
        Context.RatingChangeCategories.Load();

        return ConvertResidentWithDocuments(
            Context.Residents.First(r => r.ResidentId == id));
    }

    public IEnumerable<Resident> GetAllResidents()
    {
        return GetAllResidents(DateTime.MinValue);
    }

    public IEnumerable<Resident> GetAllResidents(DateTime documentsDate)
    {
        return Context.Residents
            .OrderBy(r => r.RoomId == null)
            .ThenBy(r => r.LastName)
            .Select(ConvertResident);
    }

    public IEnumerable<Resident> GetAllResidents(string gender,
        DateTime documentsDate)
    {
        return GetAllResidents(documentsDate)
            .Where(r => r.Gender == char.Parse(gender));
    }

    public bool IsExists(int id)
    {
        return Context.Residents.FirstOrDefault(r => r.ResidentId == id) is not
            null;
    }

    public void CreateResident(Resident resident)
    {
        var entity = new ResidentDb
        {
            FirstName = resident.FirstName, LastName = resident.LastName,
            Gender = resident.Gender, Patronymic = resident.Patronymic,
            BirthDate = resident.BirthDate, Course = resident.Course,
            IsCommercial = resident.IsCommercial, Tin = resident.Tin,
            PassportInformation = new PassportInformationDb
            {
                ResidentId = resident.Id,
                Address = resident.PassportInformation.Address,
                DepartmentCode = resident.PassportInformation.DepartmentCode,
                IssueDate = resident.PassportInformation.IssueDate,
                IssuedBy = resident.PassportInformation.IssuedBy,
                SeriesAndNumber = resident.PassportInformation.SeriesAndNumber
            }
        };

        Context.Add(entity);
    }

    public void UpdateResident(Resident resident)
    {
        var entity = Context.Residents.First(r => r.ResidentId == resident.Id);
        entity.FirstName = resident.FirstName;
        entity.LastName = resident.LastName;
        entity.Patronymic = resident.Patronymic;
        entity.BirthDate = resident.BirthDate;
        entity.Gender = resident.Gender;
        entity.Tin = resident.Tin;
        entity.Course = resident.Course;
        entity.IsCommercial = resident.IsCommercial;
        entity.PassportInformation = entity.PassportInformation;
    }

    public void DeleteResident(int id)
    {
        var resident = Context.Residents.First(r => r.ResidentId == id);
        Context.Residents.Remove(resident);
    }
}