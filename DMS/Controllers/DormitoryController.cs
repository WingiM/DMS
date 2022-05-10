using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Route("/api/stats")]
[Authorize]
public class DormitoryController : MyBaseController
{
    private readonly ILogger<DormitoryController> _logger;
    private readonly DormitoryResource _resource;

    public DormitoryController(ILogger<DormitoryController> logger,
        DormitoryResource resource)
    {
        _logger = logger;
        _resource = resource;
    }

    [HttpGet]
    public IResult GetDormitoryCapacity()
    {
        return Results.Ok(_resource.GetDormitoryCapacity());
    }

    [HttpGet]
    [Route("/api/stats/constants")]
    public IResult GetConstants()
    {
        return Results.Ok(_resource.GetConstants());
    }

    [HttpPost]
    [Route("/api/stats/constants")]
    public async Task<IResult> SetConstants()
    {
        var data = await ParseRequestBody();

        if (data is null)
            return Results.BadRequest("Error parsing request body");

        var res = _resource.SetConstants(data);

        if (!res.Item1)
        {
            Response.StatusCode = 409;
            return Results.Conflict(res.Item2);
        }


        return Results.Ok(
            $"Setting completed. The following keys were not added: {res.Item2}");
    }
}