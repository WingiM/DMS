using DMS.Core.Objects.Documents.Interfaces;
using DMS.Core.Objects.Residents;
using DMS.Core.Objects.ServiceInterfaces;

namespace DMS.Core.Objects.Documents;

public class DocumentService : IDocumentService
{
    private IDocumentsResource _documentsResource;

    public DocumentService(IDocumentsResource documentsResource)
    {
        _documentsResource = documentsResource;
    }


    public IQueryable GetAllRatingChangeCategories()
    {
        return _documentsResource.GetAllRatingChangeCategories();
    }

    public IEnumerable<Resident> GetAllDocuments(DateTime documentsStartDate)
    {
        return _documentsResource.GetAllDocuments();
    }

    public IEnumerable<Resident> GetAllDocuments()
    {
        return _documentsResource.GetAllDocuments();
    }

    public void AddDocument<T>(string data) where T : class
    {
        _documentsResource.AddDocument<T>(data);
    }

    public void DeleteDocument<T>(string data) where T : class
    {
        _documentsResource.DeleteDocument<T>(data);
    }
}