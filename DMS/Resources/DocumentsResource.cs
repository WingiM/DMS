using System.Text.Json;
using DMS.Exceptions;
using DMS.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS.Resources;

public class DocumentsResource : ResourceBase
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
                "Failed to deserialize a document");
            throw new InvalidRequestDataException(GetExceptionMessage(e), e);
        }
    }

    public void AddDocument<T>(string data) where T : class
    {
        var document = DeserializeDocument<T>(data);

        switch (document)
        {
            case Transaction t:
                CreateTransaction(t);
                break;
            case RatingOperation ro:
                CreateRatingOperation(ro);
                break;
            case SettlementOrder so:
                CreateSettlementOrder(so);
                break;
            case EvictionOrder eo:
                CreateEvictionOrder(eo);
                break;
        }
    }

    public void DeleteDocument<T>(string data) where T : class
    {
        try
        {
            var document = DeserializeDocument<T>(data);

            switch (document)
            {
                case Transaction t:
                    _context.Transactions.Remove(t);
                    break;
                case RatingOperation ro:
                    _context.RatingOperations.Remove(ro);
                    break;
                case SettlementOrder:
                case EvictionOrder:
                    throw new InvalidRequestDataException(
                        "Orders cannot be deleted");
                default:
                    throw new InvalidRequestDataException(
                        "Document type is unknown or unspecified");
            }

            _context.SaveChanges();
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }

    private void CreateSettlementOrder(SettlementOrder so)
    {
        try
        {
            var resident =
                _context.Residents.First(r => r.ResidentId == so.ResidentId);
            var room = _context.Rooms.First(r => r.RoomId == so.RoomId);

            if (resident.RoomId != null)
                throw new Exception("Resident already has a room.");

            if (resident.Gender != room.Gender)
                throw new Exception(
                    "Cannot settle resident into room with different gender");

            if (_context.Residents.Count(r => r.RoomId == room.RoomId) ==
                room.Capacity)
                throw new Exception("Room is overcrowded");

            _context.SettlementOrders.Add(so);
            _context.SaveChanges();

            resident.RoomId = so.RoomId;
            _context.SaveChanges();
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException("Invalid room or resident id",
                e);
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }

    private void CreateEvictionOrder(EvictionOrder eo)
    {
        try
        {
            var resident =
                _context.Residents.First(r => r.ResidentId == eo.ResidentId);

            if (resident.RoomId is null)
                throw new Exception("Resident is already evicted");

            _context.EvictionOrders.Add(eo);
            resident.RoomId = null;
            _context.SaveChanges();
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException("Invalid resident id", e);
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }

    private void CreateRatingOperation(RatingOperation ro)
    {
        try
        {
            var resident =
                _context.Residents.First(r => r.ResidentId == ro.ResidentId);

            if (resident.RoomId is null)
                throw new Exception("Resident is evicted");

            _context.RatingOperations.Add(ro);
            _context.SaveChanges();
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException("Invalid resident id", e);
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }

    private void CreateTransaction(Transaction t)
    {
        try
        {
            var resident =
                _context.Residents.First(r => r.ResidentId == t.ResidentId);

            if (resident.RoomId is null)
                throw new Exception("Resident is evicted");

            _context.Transactions.Add(t);
            _context.SaveChanges();
        }
        catch (InvalidOperationException e)
        {
            throw new InvalidOperationException("Invalid resident id", e);
        }
        catch (DbUpdateException e)
        {
            throw new DbUpdateException(GetExceptionMessage(e), e);
        }
    }
}