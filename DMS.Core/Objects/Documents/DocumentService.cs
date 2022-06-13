using DMS.Core.Objects.Documents.Interfaces;
using DMS.Core.Objects.Residents;
using DMS.Core.Objects.Rooms;
using DMS.Core.Objects.ServiceInterfaces;

namespace DMS.Core.Objects.Documents;

public class DocumentService : IDocumentService
{
    private readonly IDocumentsResource _documentsResource;
    private readonly IDataContext _dataContext;

    public DocumentService(IDocumentsResource documentsResource,
        IDataContext dataContext)
    {
        _documentsResource = documentsResource;
        _dataContext = dataContext;
    }

    public IEnumerable<RatingChangeCategory> GetAllRatingChangeCategories()
    {
        return _documentsResource.GetAllRatingChangeCategories();
    }

    public IEnumerable<Resident> GetAllDocuments()
    {
        return _documentsResource.GetAllDocuments();
    }

    public IEnumerable<Resident> GetAllDocuments(DateTime documentsStartDate)
    {
        return _documentsResource.GetAllDocuments(documentsStartDate);
    }

    public void AddSettlementOrder(int residentId, DateTime documentDate,
        int roomId,
        string? description, ParentData parentData)
    {
        var settlementOrder = new SettlementOrder
        {
            ParentData = parentData, Description = description,
            PostDate = documentDate,
            Resident = new Resident { Id = residentId },
            Room = new Room { Id = roomId }
        };

        _documentsResource.AddDocument(settlementOrder);
        _documentsResource.UpdateResidentRoomAfterOrder(settlementOrder,
            settlementOrder.Room.Id);
        _dataContext.SaveChanges();
    }

    public void AddEvictionOrder(int residentId, DateTime documentDate,
        string? description)
    {
        var evictionOrder = new EvictionOrder
        {
            Description = description, PostDate = documentDate,
            Resident = new Resident { Id = residentId }
        };

        _documentsResource.AddDocument(evictionOrder);
        _documentsResource.UpdateResidentRoomAfterOrder(evictionOrder, null);
        _dataContext.SaveChanges();
    }

    public void AddRatingOperation(int residentId, DateTime documentDate,
        int changeValue,
        RatingChangeCategory category)
    {
        var ratingOperation = new RatingOperation
        {
            PostDate = documentDate,
            Resident = new Resident { Id = residentId },
            ChangeValue = changeValue, Category = category
        };

        _documentsResource.AddDocument(ratingOperation);
        _dataContext.SaveChanges();
    }

    public void AddTransaction(int residentId, DateTime documentDate,
        double sum)
    {
        var transaction = new Transaction
        {
            PostDate = documentDate,
            Resident = new Resident { Id = residentId },
            Sum = sum
        };

        _documentsResource.AddDocument(transaction);
        _dataContext.SaveChanges();
    }

    public void DeleteDocument(IDocument document)
    {
        _documentsResource.DeleteDocument(document);
        _dataContext.SaveChanges();
    }
}