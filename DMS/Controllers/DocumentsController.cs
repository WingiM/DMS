using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Authorize]
[Route("/api/documents")]
public class DocumentsController
{
    private readonly ILogger<DocumentsController> _logger;
    private readonly DocumentsResource _resource;

    public DocumentsController(ILogger<DocumentsController> logger,
        DocumentsResource resource)
    {
        _logger = logger;
        _resource = resource;
    }

    [HttpGet]
    public IResult GetAllDocuments()
    {
        return Results.Ok(_resource.GetAllDocuments());
    }

    [HttpGet]
    [Route("/api/documents/categories")]
    public IResult GetAllRatingChangeCategories()
    {
        return Results.Ok(_resource.GetAllRatingChangeCategories());
    }
}