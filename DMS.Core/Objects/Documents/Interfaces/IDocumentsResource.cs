using DMS.Core.Objects.Residents;

namespace DMS.Core.Objects.Documents.Interfaces;

public interface IDocumentsResource
{
    public IEnumerable<RatingChangeCategory> GetAllRatingChangeCategories();
    public IEnumerable<Resident> GetAllDocuments();
    public IEnumerable<Resident> GetAllDocuments(DateTime documentsStartDate);
    public void AddDocument<T>(T document) where T : IDocument;
    public void UpdateResidentRoomAfterOrder(IOrder order, int? room);
    public void DeleteDocument<T>(T document) where T : IDocument;
}