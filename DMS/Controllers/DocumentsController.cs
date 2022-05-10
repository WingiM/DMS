using DMS.Models;
using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Authorize]
[Route("/api/documents")]
public class DocumentsController : MyBaseController
{
    private readonly ILogger<DocumentsController> _logger;
    private readonly DocumentsResource _documentsResource;
    private readonly ResidentResource _residentResource;

    public DocumentsController(ILogger<DocumentsController> logger,
        DocumentsResource documentsResource, ResidentResource residentResource)
    {
        _logger = logger;
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
        var documentType = Request.Headers["type"];
        if (documentType.Count == 0)
            return Results.BadRequest("Document type is not specified");

        string? data = await ParseRequestBody();

        if (data is null)
            return Results.BadRequest("Error parsing request body");

        Tuple<bool, string?> res;
        switch (documentType)
        {
            case "EvictionOrder":
                res = _documentsResource.AddDocument<EvictionOrder>(data);
                break;
            case "SettlementOrder":
                res = _documentsResource.AddDocument<SettlementOrder>(data);
                break;
            case "RatingOperation":
                res = _documentsResource.AddDocument<RatingOperation>(data);
                break;
            case "Transaction":
                res = _documentsResource.AddDocument<Transaction>(data);
                break;
            default:
                Response.StatusCode = 409;
                return Results.Conflict("Unknown document type");
        }

        if (!res.Item1)
        {
            Response.StatusCode = 409;
            return Results.Conflict(res.Item2);
        }
        
        return Results.Ok(res.Item2);
    }

    [HttpDelete]
    public async Task<IResult> DeleteDocument()
    {
        var documentType = Request.Headers["type"];
        if (documentType.Count == 0)
            return Results.BadRequest("Document type is not specified");
        
        string? data = await ParseRequestBody();

        if (data is null)
            return Results.BadRequest("Error parsing request body");

        Tuple<bool, string?> res;
        switch (documentType)
        {
            case "RatingOperation":
                res = _documentsResource.DeleteDocument<RatingOperation>(data);
                break;
            case "Transaction":
                res = _documentsResource.DeleteDocument<Transaction>(data);
                break;
            default:
                Response.StatusCode = 409;
                return Results.Conflict("Unknown document type");
        }

        return Results.Ok(res.Item2);
    }

    [HttpGet]
    [Route("/api/documents/categories")]
    public IResult GetAllRatingChangeCategories()
    {
        return Results.Ok(_documentsResource.GetAllRatingChangeCategories());
    }
}