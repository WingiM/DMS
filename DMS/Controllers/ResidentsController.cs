using DMS.Core.Exceptions;
using DMS.Core.Objects.ServiceInterfaces;
using DMS.Data.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Authorize]
[Route("/api/[controller]")]
public class ResidentsController : DmsControllerBase
{
    private readonly IResidentService _service;

    public ResidentsController(IResidentService service)
    {
        _service = service;
    }

    [HttpGet]
    public IResult GetAllResidents()
    {
        DateTime resultDate = ParseDate(Request.Headers["date"]);
        var gender = Request.Headers["gender"];

        return Results.Ok(_service.GetAllResidents(resultDate, gender));
    }

    [HttpPost]
    public async Task<IResult> AddResident()
    {
        try
        {
            var data = await ParseRequestBody();
            var id = _service.AddResident(data);
            return Results.Json(new
            {
                message = "Added successfully",
                ResidentId = id
            });
        }
        catch (InvalidOperationException e)
        {
            return Results.BadRequest(e.Message);
        }
        catch (Exception e)
        {
            return Results.Conflict(e.Message);
        }
    }

    [HttpGet]
    [Route("/api/[controller]/{id:int}")]
    public IResult GetResidentById(int id)
    {
        try
        {
            DateTime resultDate = ParseDate(Request.Headers["date"]);
            var res = _service.GetResidentById(id, resultDate);
            return Results.Ok(res);
        }
        catch (InvalidOperationException)
        {
            return Results.Conflict("No resident with this ID");
        }
        
    }

    [HttpPut]
    [Route("/api/[controller]/{id:int}")]
    public async Task<IResult> UpdateResidentInfo(int id)
    {
        try
        {
            var data = await ParseRequestBody();
            _service.UpdateResident(id, data);
            return Results.Ok("Updated successfully");
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

    [HttpDelete]
    [Route("/api/[controller]/{id:int}")]
    public IResult DeleteResident(int id)
    {
        try
        {
            _service.DeleteResident(id);
            return Results.Ok("Deleted successfully");
        }
        catch (InvalidOperationException e)
        {
            return Results.BadRequest(e.Message);
        }
        catch (Exception e)
        {
            return Results.Conflict(e.Message);
        }
    }
}