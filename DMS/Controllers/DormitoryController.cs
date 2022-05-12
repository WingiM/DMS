using DMS.Exceptions;
using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DMS.Controllers;

[ApiController]
[Route("/api/stats")]
[Authorize]
public class DormitoryController : DmsControllerBase
{
    private readonly DormitoryResource _resource;
    private readonly ResidentResource _residentResource;

    public DormitoryController(DormitoryResource resource,
        ResidentResource residentResource)
    {
        _resource = resource;
        _residentResource = residentResource;
    }

    [HttpGet]
    public IResult GetDormitoryCapacity()
    {
        return Results.Ok(_resource.GetDormitoryCapacity());
    }

    [HttpGet]
    [Route("/api/stats/resettlement")]
    public IResult GetResettlementLists()
    {
        var residents = _residentResource.GetAllResidents().ToList();

        var firstCourses = residents
            .Where(r => r.Course == 1)
            .OrderBy(r => r.LastName)
            .Select(ConvertResident);

        var others = residents
            .Where(r => r.Course != 1)
            .OrderByDescending(r => r.CountRating())
            .ThenBy(r => r.LastName)
            .Select(ConvertResident);

        return Results.Ok(firstCourses.Concat(others));
    }

    [HttpPost]
    [Route("/api/stats/accruals")]
    public IResult AccrualAllResidents()
    {
        try
        {
            var commercialCost = -1 * int.Parse(_resource.GetConstant(
                "CommercialCost"));
            var nonCommercialCost = -1 * int.Parse(_resource.GetConstant(
                "NonCommercialCost"));

            _residentResource.AccrualAll(commercialCost, nonCommercialCost);
            return Results.Ok("Transactions complete");
        }
        catch (FormatException)
        {
            return Results.BadRequest(
                "Dormitory constants not set or have bad value");
        }
        catch (DbUpdateException e)
        {
            return Results.Conflict(e.Message);
        }
    }

    [HttpGet]
    [Route("/api/stats/constants")]
    public IResult GetConstants()
    {
        return Results.Ok(_resource.GetConstants());
    }

    [HttpGet]
    [Route("/api/stats/constants/{name}")]
    public IResult GetConstant(string name)
    {
        return Results.Ok(_resource.GetConstant(name));
    }

    [HttpPost]
    [Route("/api/stats/constants")]
    public async Task<IResult> SetConstants()
    {
        try
        {
            var data = await ParseRequestBody();
            var res = _resource.SetSafeConstants(data);
            
            return Results.Ok(
                "Setting completed." + res == ""
                    ? ""
                    : $"The following keys were not added: {res}");
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

    [HttpPost]
    [Route("/api/stats/reset")]
    public async Task<IResult> ResetDormitory()
    {
        try
        {
            var data = await ParseRequestBody();

            _resource.SetHardResetConstants(data);
            _residentResource.EvictAll();
            _resource.ResetRooms();

            return Results.Ok("Reset complete");
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