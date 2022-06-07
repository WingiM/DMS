using DMS.Core.Exceptions;
using DMS.Core.Objects.Residents;
using DMS.Core.Objects.ServiceInterfaces;
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
    private readonly IDocumentService _documentsService;
    private readonly IResidentService _residentService;

    public DocumentsController(IDocumentService documentsService,
        IResidentService residentService)
    {
        _documentsService = documentsService;
        _residentService = residentService;
    }

    [HttpGet]
    public IResult GetAllDocuments()
    {
        return Results.Ok(_residentService.GetAllResidents());
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
                    _documentsService.AddDocument<EvictionOrderDb>(data);
                    break;
                case "SettlementOrder":
                    _documentsService.AddDocument<SettlementOrderDb>(data);
                    break;
                case "RatingOperation":
                    _documentsService.AddDocument<RatingOperationDb>(data);
                    break;
                case "Transaction":
                    _documentsService.AddDocument<TransactionDb>(data);
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
                    _documentsService.DeleteDocument<RatingOperationDb>(data);
                    break;
                case "Transaction":
                    _documentsService.DeleteDocument<TransactionDb>(data);
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
        return Results.Ok(_documentsService.GetAllRatingChangeCategories());
    }
}