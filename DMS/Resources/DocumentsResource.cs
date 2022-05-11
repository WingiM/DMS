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
        try
        {
            return JsonSerializer.Deserialize<T>(data);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information,
                "Failed to create a document:\n" + e);
            return null;
        }
    }

    public Tuple<bool, string?> AddDocument<T>(string data) where T : class
    {
        var document = DeserializeDocument<T>(data);
        if (document is null)
            return new Tuple<bool, string?>(false,
                "Error parsing request body");

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

    public Tuple<bool, string?> DeleteDocument<T>(string data) where T : class
    {
        var document = DeserializeDocument<T>(data);
        if (document is null)
            return new Tuple<bool, string?>(false,
                "Error parsing request body");

        try
        {
            switch (document)
            {
                case Transaction t:
                    _logger.Log(LogLevel.Information, "Im here");
                    _context.Transactions.Remove(t);
                    break;
                case RatingOperation ro:
                    _context.RatingOperations.Remove(ro);
                    break;
                case SettlementOrder:
                case EvictionOrder:
                    return new Tuple<bool, string?>(false,
                        "Cannot delete orders");
                default:
                    return new Tuple<bool, string?>(false,
                        "Unknown document type");
            }

            _context.SaveChanges();
            return new Tuple<bool, string?>(true, "Delete complete");
        }
        catch (Exception)
        {
            return new Tuple<bool, string?>(false, "Error deleting document");
        }
    }

    private Tuple<bool, string?> CreateSettlementOrder(SettlementOrder so)
    {
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

            return new Tuple<bool, string?>(true, "Settled successfully");
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information, e.ToString());
            return new Tuple<bool, string?>(false, GetErrorMessage(e));
        }
    }

    private Tuple<bool, string?> CreateEvictionOrder(EvictionOrder eo)
    {
        try
        {
            var resident = _context.Residents.FirstOrDefault(r =>
                r.ResidentId == eo.ResidentId);

            if (resident is null)
                return new Tuple<bool, string?>(false,
                    "No resident with this id");

            if (resident.RoomId is null)
                return new Tuple<bool, string?>(false,
                    "Resident is already evicted");

            _context.EvictionOrders.Add(eo);
            resident.RoomId = null;
            _context.SaveChanges();
            return new Tuple<bool, string?>(true, "Evicted successfully");
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information, e.ToString());
            return new Tuple<bool, string?>(false, GetErrorMessage(e));
        }
    }

    private Tuple<bool, string?> CreateRatingOperation(RatingOperation ro)
    {
        try
        {
            var resident = _context.Residents.FirstOrDefault(r =>
                r.ResidentId == ro.ResidentId);

            if (resident is null)
                return new Tuple<bool, string?>(false,
                    "No resident with this id");

            if (resident.RoomId is null)
                return new Tuple<bool, string?>(false, "Resident is evicted");

            _context.RatingOperations.Add(ro);
            _context.SaveChanges();
            return new Tuple<bool, string?>(true, "Rating changed");
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information, e.ToString());
            return new Tuple<bool, string?>(false, GetErrorMessage(e));
        }
    }

    private Tuple<bool, string?> CreateTransaction(Transaction t)
    {
        try
        {
            var resident = _context.Residents.FirstOrDefault(r =>
                r.ResidentId == t.ResidentId);

            if (resident is null)
                return new Tuple<bool, string?>(false,
                    "No resident with this id");
            
            if (resident.RoomId is null)
                return new Tuple<bool, string?>(false, "Resident is evicted");

            _context.Transactions.Add(t);
            _context.SaveChanges();
            return new Tuple<bool, string?>(true, "Transaction complete");
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information, e.ToString());
            return new Tuple<bool, string?>(false, GetErrorMessage(e));
        }
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