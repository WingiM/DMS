using DMS.Core.Exceptions;
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
        Context.Rooms.Load();

        return ConvertResidentWithDocuments(
            Context.Residents.FirstOrDefault(r => r.ResidentId == id) ??
            throw new DataException("Resident not found"));
    }

    public IEnumerable<Resident> GetAllResidents()
    {
        return GetAllResidents(DateTime.MinValue);
    }

    public IEnumerable<Resident> GetAllResidents(DateTime documentsDate)
    {
        Context.Rooms.Load();
        Context.Passports.Load();
        return Context.Residents
            .OrderBy(r => r.RoomId == null)
            .ThenBy(r => r.LastName)
            .Select(ConvertResident);
    }

    public IEnumerable<Resident> GetAllResidents(DateTime documentsDate,
        string gender)
    {
        return GetAllResidents(documentsDate)
            .Where(r => r.Gender == char.Parse(gender));
    }

    public IEnumerable<Resident> GetAllResidents(string gender)
    {
        return GetAllResidents(DateTime.MinValue, gender);
    }

    public bool IsExists(int id)
    {
        return Context.Residents.FirstOrDefault(r => r.ResidentId == id) is not
            null;
    }

    public int CreateResident(Resident resident)
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
        Context.SaveChanges();
        return entity.ResidentId;
    }

    public void UpdateResident(Resident resident)
    {
        var entity =
            Context.Residents.FirstOrDefault(r =>
                r.ResidentId == resident.Id) ??
            throw new DataException("Resident not found");
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
        var resident =
            Context.Residents.FirstOrDefault(r => r.ResidentId == id) ??
            throw new DataException("Resident not found");
        Context.Residents.Remove(resident);
    }
}