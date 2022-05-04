using DMS.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS.Resources;

public class DocumentsResource
{
    private readonly ApplicationContext _context;
    private readonly ILogger<DocumentsResource> _logger;

    public DocumentsResource(ApplicationContext context,
        ILogger<DocumentsResource> logger)
    {
        _context = context;
        _logger = logger;
    }

    public IEnumerable<IQueryable> GetAllDocuments()
    {
        return new IQueryable[]
        {
            _context.SettlementOrders,
            _context.EvictionOrders,
            _context.RatingOperations
        };
    }

    public IQueryable GetAllRatingChangeCategories()
    {
        return _context.RatingChangeCategories;
    }
}