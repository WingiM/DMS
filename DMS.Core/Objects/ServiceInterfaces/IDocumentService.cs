using DMS.Core.Objects.Residents;

namespace DMS.Core.Objects.ServiceInterfaces;

public interface IDocumentService
{
    public IQueryable GetAllRatingChangeCategories();
    public IEnumerable<Resident> GetAllDocuments(DateTime documentsStartDate);
    public IEnumerable<Resident> GetAllDocuments();
    public void AddDocument<T>(string data) where T : class;
    public void DeleteDocument<T>(string data) where T : class;
}