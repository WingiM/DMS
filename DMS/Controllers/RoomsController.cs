using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;


[ApiController]
[Authorize]
[Route("/api/[controller]")]
public class RoomsController
{
    private readonly ILogger<RoomsController> _logger;
    private readonly RoomResource _resource;

    public RoomsController(RoomResource resource, ILogger<RoomsController> logger)
    {
        _logger = logger;
        _resource = resource;
    }

    [HttpGet]
    public IResult Get(int? id, int? floor)
    {
        if (floor is not null)
        {
            var res = _resource.GetByFloorNumber(floor.Value).ToArray();
            if (!res.Any())
            {
                return Results.BadRequest("Floor number incorrect");
            }
            return Results.Ok(res.Select(r=>r.RoomId));
        }
        
        if (id is not null)
        {
            var res = _resource.GetById(id.Value);
            if (res is null)
            {
                return Results.BadRequest("Room id incorrect");
            }
            return Results.Ok(res);
        }
        
        return Results.Ok(_resource.GetAll());
    }
}