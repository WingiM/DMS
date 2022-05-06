using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Authorize]
[Route("/api/documents")]
public class DocumentsController : ControllerBase
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
    //
    // [HttpPost]
    // public IResult CreateDocument()
    // {
    //     var documentType = Request.Headers["type"];
    //     if (documentType.Count == 0)
    //         return Results.BadRequest("Document type is not specified");
    // }

    [HttpGet]
    [Route("/api/documents/categories")]
    public IResult GetAllRatingChangeCategories()
    {
        return Results.Ok(_documentsResource.GetAllRatingChangeCategories());
    }
}