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

    public RoomsController(RoomResource resource,
        ILogger<RoomsController> logger)
    {
        _logger = logger;
        _resource = resource;
    }

    [HttpGet]
    [Route("/api/rooms/{id:int}")]
    public IResult GetWithId(int id)
    {
        var res = _resource.GetRoomById(id);
        if (res is null)
        {
            return Results.BadRequest("Room id incorrect");
        }

        return Results.Ok(res);
    }

    [HttpGet]
    [Route("/api/rooms/floors/{floor:int}")]
    public IResult GetWithFloorNumber(int floor)
    {
        var res = _resource.GetAllRoomsOnFloor(floor).ToArray();
        if (!res.Any())
        {
            return Results.BadRequest("Floor number incorrect");
        }

        return Results.Ok(res.Select(r => r.RoomId));
    }

    [HttpGet]
    [Route("/api/rooms/floors")]
    public IResult GetFloors()
    {
        var res = _resource.GetFloorsCount();
        return Results.Ok(res);
    }
}