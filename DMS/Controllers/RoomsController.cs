using DMS.Core.Exceptions;
using DMS.Core.Objects.ServiceInterfaces;
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
    private readonly IRoomService _service;

    public RoomsController(IRoomService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("/api/rooms/{id:int}")]
    public IResult GetWithId(int id)
    {
        DateTime resultDate = ParseDate(Request.Headers["date"]);
        var room = _service.GetRoomWithResidents(id, resultDate);
        return Results.Ok(room);
    }

    [HttpGet]
    [Route("/api/rooms/floors/{floor:int}")]
    public IResult GetWithFloorNumber(int floor)
    {
        var res = _service.GetAllRoomsOnFloor(floor).ToArray();
        return Results.Ok(res);
    }

    [HttpGet]
    [Route("/api/rooms/floors")]
    public IResult GetFloors()
    {
        var res = _service.GetFloorsCount();
        return Results.Ok(res.OrderBy(r => r));
    }

    // [HttpPost]
    // [Route("/api/rooms/gender")]
    // public async Task<IResult> SetRoomGender()
    // {
    //     try
    //     {
    //         var data = await ParseRequestBody();
    //         _service.SetRoomGender(data);
    //         return Results.Ok("Room gender changed successfully");
    //     }
    //     catch (InvalidRequestDataException e)
    //     {
    //         return Results.BadRequest(e.Message);
    //     }
    //     catch (Exception e)
    //     {
    //         return Results.Conflict(e.Message);
    //     }
    // }
}