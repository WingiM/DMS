using System.Text.Json;
using DMS.Models;
using Npgsql;

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

    public IQueryable GetAllRatingChangeCategories()
    {
        return _context.RatingChangeCategories;
    }

    private T? DeserializeDocument<T>(string data) where T : class
    {
        T? document = null;
        try
        {
            document = JsonSerializer.Deserialize<T>(data);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information,
                "Failed to create a document:\n" + e);
        }

        return document;
    }

    public Tuple<bool, string?> AddDocument<T>(string data) where T : class
    {
        var document = DeserializeDocument<T>(data);
        if (document is null)
            return new Tuple<bool, string?>(false,
                "Error parsing request body");

        _logger.Log(LogLevel.Information, "I'm here!");
        switch (document)
        {
            case Transaction t:
                return CreateTransaction(t);
            case RatingOperation ro:
                return CreateRatingOperation(ro);
            case SettlementOrder so:
                return CreateSettlementOrder(so);
            case EvictionOrder eo:
                return CreateEvictionOrder(eo);
            default:
                return new Tuple<bool, string?>(false, "Unknown document type");
        }
    }

    private Tuple<bool, string?> CreateSettlementOrder(SettlementOrder so)
    {
        string? errorMessage;
        try
        {
            var resident = _context.Residents.FirstOrDefault(r =>
                r.ResidentId == so.ResidentId);
            var room =
                _context.Rooms.FirstOrDefault(r => r.RoomId == so.RoomId);

            if (resident is null)
                return new Tuple<bool, string?>(false,
                    "No resident with this id");

            if (room is null)
                return new Tuple<bool, string?>(false, "No room with this id");

            if (resident.RoomId != null)
                return new Tuple<bool, string?>(false,
                    "Resident already has a room.");

            if (resident.Gender != room.Gender)
                return new Tuple<bool, string?>(false,
                    "Cannot settle resident into room with different gender");

            if (_context.Residents.Count(r => r.RoomId == room.RoomId) ==
                room.Capacity)
                return new Tuple<bool, string?>(false, "Room is overcrowded");

            _context.SettlementOrders.Add(so);
            _context.SaveChanges();

            resident.RoomId = so.RoomId;
            _context.SaveChanges();

            return new Tuple<bool, string?>(true, null);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information, e.ToString());
            errorMessage = GetErrorMessage(e);
        }

        return new Tuple<bool, string?>(false, errorMessage);
    }
    
    
    // TODO: Other 3 documents
    private Tuple<bool, string?> CreateEvictionOrder(EvictionOrder eo)
    {
        return null;
    }

    private Tuple<bool, string?> CreateRatingOperation(RatingOperation ro)
    {
        return null;
    }

    private Tuple<bool, string?> CreateTransaction(Transaction t)
    {
        return null;
    }
    
    private string GetErrorMessage(Exception e)
    {
        switch (e.InnerException)
        {
            case PostgresException pe:
                return pe.MessageText;
            case InvalidCastException ice:
                return ice.Message;
            case JsonException je:
                return je.Message;
            case IndexOutOfRangeException oor:
                return oor.Message;
            default:
                return "Unknown error";
        }
    }
}