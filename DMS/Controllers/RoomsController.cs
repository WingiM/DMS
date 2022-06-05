using DMS.Core.Exceptions;
using DMS.Data.Models;
using DMS.Data.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Authorize]
[Route("/api/[controller]")]
public class RoomsController : DmsControllerBase
{
    private static readonly Func<RoomDb, object> ConvertRoom =
        room => new
        {
            room.RoomId, room.Capacity, room.Gender, room.FloorNumber,
            Residents = room.Residents
                .OrderBy(r => r.LastName)
                .Select(ConvertResident)
        };
    
    private readonly RoomResource _resource;

    public RoomsController(RoomResource resource)
    {
        _resource = resource;
    }

    [HttpGet]
    [Route("/api/rooms/{id:int}")]
    public IResult GetWithId(int id)
    {
        try
        {
            DateTime resultDate = ParseDate(Request.Headers["date"]);
            var room = _resource.GetRoomWithResidents(id, resultDate);
            return Results.Ok(ConvertRoom(room));
        }
        catch (InvalidOperationException e)
        {
            return Results.BadRequest(e.Message);
        }
    }

    [HttpGet]
    [Route("/api/rooms/floors/{floor:int}")]
    public IResult GetWithFloorNumber(int floor)
    {
        var res = _resource.GetAllRoomsOnFloor(floor).ToArray();
        return Results.Ok(res
            .OrderBy(r => r.RoomId)
            .Select(r => new
            { r.RoomId, IsFull = r.Capacity == r.Residents.Count }));
    }

    [HttpGet]
    [Route("/api/rooms/floors")]
    public IResult GetFloors()
    {
        var res = _resource.GetFloorsCount();
        return Results.Ok(res.OrderBy(r => r));
    }

    [HttpPost]
    [Route("/api/rooms/gender")]
    public async Task<IResult> SetRoomGender()
    {
        try
        {
            var data = await ParseRequestBody();
            _resource.SetRoomGender(data);
            return Results.Ok("Room gender changed successfully");
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
}