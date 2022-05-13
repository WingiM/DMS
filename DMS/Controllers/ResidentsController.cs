using DMS.Exceptions;
using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Authorize]
[Route("/api/[controller]")]
public class ResidentsController : DmsControllerBase
{
    private readonly ResidentResource _resource;

    public ResidentsController(ResidentResource resource)
    {
        _resource = resource;
    }

    [HttpGet]
    public IResult GetAllResidents()
    {
        DateTime resultDate = ParseDate(Request.Headers["date"]);
        var gender = Request.Headers["gender"];

        return Results.Ok(
            _resource.GetAllResidents(resultDate, gender)
                .Select(ConvertResident)
        );
    }

    [HttpPost]
    public async Task<IResult> AddResident()
    {
        try
        {
            var data = await ParseRequestBody();
            _resource.AddResident(data);
            return Results.Ok("Added successfully");
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
            var res = _resource.GetResidentById(id, resultDate);
            return Results.Ok(ConvertResident(res));
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
            _resource.UpdateResident(id, data);
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
            _resource.DeleteResident(id);
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