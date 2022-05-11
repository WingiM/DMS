using DMS.Models;
using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Authorize]
[Route("/api/[controller]")]
public class RoomsController : DmsControllerBase
{
    private static readonly Func<Room, object> ConvertRoom =
        room => new
        {
            room.RoomId, room.Capacity, room.Gender, room.FloorNumber,
            Residents = room.Residents
                .OrderBy(r => r.LastName)
                .Select(ConvertResident)
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
        DateTime resultDate = ParseDate(Request.Headers["date"]);

        var room = _resource.GetRoomWithResidents(id, resultDate);
        if (room is null)
        {
            return Results.BadRequest("Room id incorrect");
        }

        return Results.Ok(ConvertRoom(room));
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

        return Results.Ok(res.Select(r => new
            { r.RoomId, IsFull = r.Capacity == r.Residents.Count }));
    }

    [HttpGet]
    [Route("/api/rooms/floors")]
    public IResult GetFloors()
    {
        var res = _resource.GetFloorsCount();
        return Results.Ok(res);
    }

    [HttpPost]
    [Route("/api/rooms/gender")]
    public async Task<IResult> SetRoomGender()
    {
        var data = await ParseRequestBody();

        if (data is null)
            return Results.BadRequest("Could not parse request body");

        var res = _resource.SetRoomGender(data);

        if (!res.Item1)
        {
            Response.StatusCode = 409;
            return Results.Conflict($"Cannot change room gender: {res.Item2}");
        }

        return Results.Ok("Gender changed successfully");
    }
}