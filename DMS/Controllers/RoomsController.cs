using DMS.Models;
using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Authorize]
[Route("/api/[controller]")]
public class RoomsController : ControllerBase
{
    private static readonly Func<Room, DateTime, object> ConvertRoom =
        (room, date) => new
        {
            room.RoomId, room.Capacity, room.Gender, room.FloorNumber,
            Residents = room.Residents.Select(r =>
                ResidentsController.ConvertResident(r, date))
        };

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
        var room = _resource.GetRoomById(id);
        if (room is null)
        {
            return Results.BadRequest("Room id incorrect");
        }

        Request.Headers.TryGetValue("date", out var date);
        var resultDate = ResidentsController.GetDocumentsDate(date);
        Response.Headers.Add("processedDate", resultDate.ToString("u"));
        
        return Results.Ok(ConvertRoom(room, resultDate));
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