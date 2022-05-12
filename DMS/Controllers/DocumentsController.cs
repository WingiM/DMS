using DMS.Exceptions;
using DMS.Models;
using DMS.Resources;
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
        return Results.Ok(_residentResource.GetAllResidents());
    }

    [HttpPost]
    public async Task<IResult> CreateDocument()
    {
        try
        {
            var documentType = Request.Headers["type"];
            // if (documentType.Count == 0)
            //     return Results.BadRequest("Document type is not specified");

            var data = await ParseRequestBodyWithException();

            switch (documentType)
            {
                case "EvictionOrder":
                    _documentsResource.AddDocument<EvictionOrder>(data);
                    break;
                case "SettlementOrder":
                    _documentsResource.AddDocument<SettlementOrder>(data);
                    break;
                case "RatingOperation":
                    _documentsResource.AddDocument<RatingOperation>(data);
                    break;
                case "Transaction":
                    _documentsResource.AddDocument<Transaction>(data);
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
            // if (documentType.Count == 0)
            //     return Results.BadRequest("Document type is not specified");

            string data = await ParseRequestBodyWithException();

            switch (documentType)
            {
                case "RatingOperation":
                    _documentsResource.DeleteDocument<RatingOperation>(data);
                    break;
                case "Transaction":
                    _documentsResource.DeleteDocument<Transaction>(data);
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