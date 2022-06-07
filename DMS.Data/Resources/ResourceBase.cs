using DMS.Core.Objects.Documents;
using DMS.Core.Objects.Residents;
using DMS.Core.Objects.Rooms;
using DMS.Data.Models;
using Newtonsoft.Json;
using Npgsql;

namespace DMS.Data.Resources;

public abstract class ResourceBase
{
    protected readonly ApplicationContext Context;

    protected ResourceBase(ApplicationContext context)
    {
        Context = context;
    }

    protected static string GetExceptionMessage(Exception e)
    {
        switch (e.InnerException)
        {
            case PostgresException pe:
                return pe.MessageText;
            case InvalidCastException:
            case JsonException:
            case IndexOutOfRangeException:
                return e.InnerException.Message;
        }

        return e.Message;
    }

    protected static Room ConvertRoom(RoomDb roomDb)
    {
        return new Room
        {
            Id = roomDb.RoomId, Capacity = roomDb.Capacity,
            FloorNumber = roomDb.FloorNumber, Gender = roomDb.Gender,
            IsFull = roomDb.Capacity == roomDb.Residents.Count
        };
    }

    protected static Room ConvertRoomWithResidents(RoomDb roomDb)
    {
        var room = ConvertRoom(roomDb);
        room.Residents = roomDb.Residents.Select(ConvertResidentBase).ToList();
        return room;
    }

    private static Resident ConvertResidentBase(ResidentDb residentDb)
    {
        var resident = new Resident
        {
            Id = residentDb.ResidentId, LastName = residentDb.LastName,
            FirstName = residentDb.FirstName,
            Patronymic = residentDb.Patronymic,
            BirthDate = residentDb.BirthDate, Tin = residentDb.Tin,
            Course = residentDb.Course, Gender = residentDb.Gender,
            IsCommercial = residentDb.IsCommercial,
            Balance = residentDb.CountDebt(),
            Rating = residentDb.CountRating(),
            Reports = residentDb.CountReports(),
            PassportInformation =
                ConvertPassportInformation(residentDb.PassportInformation)
        };
        
        if (residentDb.Room is not null)
        {
            var room = ConvertRoom(residentDb.Room);

            room.Residents = residentDb.Room.Residents
                .Select(ConvertResidentBase).ToList();

            resident.Room = room;
        }

        return resident;
    }

    protected static Resident ConvertResident(ResidentDb residentDb)
    {
        var resident = ConvertResidentBase(residentDb);
        if (residentDb.Room is not null)
        {
            var room = ConvertRoom(residentDb.Room);

            room.Residents = residentDb.Room.Residents
                .Select(ConvertResidentBase).ToList();

            resident.Room = room;
        }

        return resident;
    }

    protected static Resident ConvertResidentWithDocuments(
        ResidentDb residentDb)
    {
        var resident = ConvertResident(residentDb);
        resident.SettlementOrders = residentDb.SettlementOrders
            .Select(ConvertSettlementOrder).ToList();
        resident.EvictionOrders = residentDb.EvictionOrders
            .Select(ConvertEvictionOrder).ToList();
        resident.RatingOperations =
            residentDb.RatingOperations.Select(ConvertRatingOperation).ToList();
        resident.Transactions =
            residentDb.Transactions.Select(ConvertTransaction).ToList();
        return resident;
    }

    private static SettlementOrder ConvertSettlementOrder(
        SettlementOrderDb settlementOrderDb)
    {
        return new SettlementOrder
        {
            Id = settlementOrderDb.SettlementOrderId,
            PostDate = settlementOrderDb.OrderDate,
            Description = settlementOrderDb.Description,
            Room = ConvertRoom(settlementOrderDb.Room),
            ParentsFullName = settlementOrderDb.ParentsFullName,
            ParentsPassportAddress = settlementOrderDb.ParentsPassportAddress,
            ParentsPassportDepartmentCode =
                settlementOrderDb.ParentsPassportDepartmentCode,
            ParentsPassportIssueDate =
                settlementOrderDb.ParentsPassportIssueDate,
            ParentsPassportIssuedBy = settlementOrderDb.ParentsPassportIssuedBy,
            ParentsPassportSeriesNumber =
                settlementOrderDb.ParentsPassportSeriesNumber
        };
    }

    private static EvictionOrder ConvertEvictionOrder(
        EvictionOrderDb evictionOrderDb)
    {
        return new EvictionOrder
        {
            Id = evictionOrderDb.EvictionOrderId,
            Description = evictionOrderDb.Description,
            PostDate = evictionOrderDb.OrderDate
        };
    }

    private static Transaction ConvertTransaction(TransactionDb transactionDb)
    {
        return new Transaction
        {
            Id = transactionDb.TransactionId,
            Sum = transactionDb.Sum,
            PostDate = transactionDb.OperationDate
        };
    }

    private static RatingOperation ConvertRatingOperation(
        RatingOperationDb ratingOperationDb)
    {
        return new RatingOperation
        {
            Id = ratingOperationDb.RatingOperationId,
            Description = ratingOperationDb.Description,
            ChangeValue = ratingOperationDb.ChangeValue,
            PostDate = ratingOperationDb.OrderDate,
            Category = new RatingChangeCategory
            {
                Id = ratingOperationDb.Category.RatingChangeCategoryId,
                Name = ratingOperationDb.Category.Name
            }
        };
    }

    protected static RatingChangeCategory ConvertRatingChangeCategory(
        RatingChangeCategoryDb ratingChangeCategoryDb)
    {
        return new RatingChangeCategory
        {
            Id = ratingChangeCategoryDb.RatingChangeCategoryId,
            Name = ratingChangeCategoryDb.Name
        };
    }

    private static PassportInformation ConvertPassportInformation(
        PassportInformationDb passportInformationDb)
    {
        return new PassportInformation
        {
            Id = passportInformationDb.PassportInformationId,
            SeriesAndNumber = passportInformationDb.SeriesAndNumber,
            Address = passportInformationDb.Address,
            DepartmentCode = passportInformationDb.DepartmentCode,
            IssueDate = passportInformationDb.IssueDate,
            IssuedBy = passportInformationDb.IssuedBy
        };
    }
}