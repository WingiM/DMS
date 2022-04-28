using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Authorize]
[Route("/api/[controller]")]
public class ResidentsController : ControllerBase
{
    private readonly ILogger<ResidentsController> _logger;
    private readonly ResidentResource _resource;

    public ResidentsController(ILogger<ResidentsController> logger, ResidentResource resource)
    {
        _logger = logger;
        _resource = resource;
    }

    [HttpGet]
    public IResult GetAll()
    {
        return Results.Ok(_resource.GetAllResidents());
    }

    [HttpDelete]
    [Route("/api/[controller]/{id:int}")]
    public IResult DeleteResident(int id)
    {
        var res = _resource.DeleteResident(id);
        if (!res)
            return Results.BadRequest("Wrong resident id");

        return Results.Ok("Deleted successfully");
    }
}