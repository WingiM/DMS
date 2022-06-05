using DMS.Core.Exceptions;
using DMS.Data.Models;
using DMS.Data.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Authorize]
[Route("/api/documents")]
public class DocumentsController : DmsControllerBase
{
    private readonly DocumentsResource _documentsResource;
    private readonly ResidentResource _residentResource;

    public DocumentsController(DocumentsResource documentsResource,
        ResidentResource residentResource)
    {
        _documentsResource = documentsResource;
        _residentResource = residentResource;
    }

    [HttpGet]
    public IResult GetAllDocuments()
    {
        return Results.Ok(_residentResource.GetAllResidents()
            .Select(r => new
            {
                r.FirstName, r.LastName, r.Course, r.Patronymic, r.IsCommercial,
                r.BirthDate, r.RoomId, r.PassportInformation, r.Tin,
                Transactions = r.Transactions
                    .OrderByDescending(t => t.OperationDate).ToList(),
                RatingOperations = r.RatingOperations
                    .OrderByDescending(t => t.OrderDate).ToList(),
                SettlementOrders = r.SettlementOrders
                    .OrderByDescending(t => t.OrderDate).ToList(),
                EvictionOrders = r.EvictionOrders
                    .OrderByDescending(t => t.OrderDate).ToList()
            }));
    }

    [HttpPost]
    public async Task<IResult> CreateDocument()
    {
        try
        {
            var documentType = Request.Headers["type"];
            var data = await ParseRequestBody();

            switch (documentType)
            {
                case "EvictionOrder":
                    _documentsResource.AddDocument<EvictionOrderDb>(data);
                    break;
                case "SettlementOrder":
                    _documentsResource.AddDocument<SettlementOrderDb>(data);
                    break;
                case "RatingOperation":
                    _documentsResource.AddDocument<RatingOperationDb>(data);
                    break;
                case "Transaction":
                    _documentsResource.AddDocument<TransactionDb>(data);
                    break;
                default:
                    Response.StatusCode = 409;
                    return Results.Conflict("Unknown document type");
            }

            return Results.Ok($"Successfully created {documentType}");
        }
        catch (InvalidRequestDataException e)
        {
            return Results.BadRequest(e.Message);
        }
        catch (Exception e)
        {
            return Results.Conflict(e.Message);
        }
    }

    [HttpDelete]
    public async Task<IResult> DeleteDocument()
    {
        try
        {
            var documentType = Request.Headers["type"];

            string data = await ParseRequestBody();

            switch (documentType)
            {
                case "RatingOperation":
                    _documentsResource.DeleteDocument<RatingOperationDb>(data);
                    break;
                case "Transaction":
                    _documentsResource.DeleteDocument<TransactionDb>(data);
                    break;
                default:
                    Response.StatusCode = 409;
                    return Results.Conflict("Unknown document type");
            }

            return Results.Ok($"Successfully deleted {documentType}");
        }
        catch (InvalidRequestDataException e)
        {
            return Results.BadRequest(e.Message);
        }
        catch (Exception e)
        {
            return Results.Conflict(e.Message);
        }
    }

    [HttpGet]
    [Route("/api/documents/categories")]
    public IResult GetAllRatingChangeCategories()
    {
        return Results.Ok(_documentsResource.GetAllRatingChangeCategories());
    }
}