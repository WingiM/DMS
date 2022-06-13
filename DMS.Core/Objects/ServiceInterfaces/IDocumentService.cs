using DMS.Core.Objects.Documents;
using DMS.Core.Objects.Documents.Interfaces;
using DMS.Core.Objects.Residents;

namespace DMS.Core.Objects.ServiceInterfaces;

public interface IDocumentService
{
    public IEnumerable<RatingChangeCategory> GetAllRatingChangeCategories();
    public IEnumerable<Resident> GetAllDocuments();
    public IEnumerable<Resident> GetAllDocuments(DateTime documentsStartDate);
    public void AddSettlementOrder(int residentId, DateTime documentDate, int roomId, string? description, ParentData parentData);
    public void AddEvictionOrder(int residentId, DateTime documentDate, string? description);
    public void AddRatingOperation(int residentId, DateTime documentDate, int changeValue, RatingChangeCategory category);
    public void AddTransaction(int residentId, DateTime documentDate, double sum);
    public void DeleteDocument(IDocument document);
}