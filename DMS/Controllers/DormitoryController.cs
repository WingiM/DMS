using System.Text;
using DMS.Models;
using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Route("/api/stats")]
[Authorize]
public class DormitoryController : DmsControllerBase
{
    private readonly ILogger<DormitoryController> _logger;
    private readonly DormitoryResource _resource;
    private readonly ResidentResource _residentResource;

    public DormitoryController(ILogger<DormitoryController> logger,
        DormitoryResource resource, ResidentResource residentResource)
    {
        _logger = logger;
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

            var result =
                _residentResource.AccrualAll(commercialCost, nonCommercialCost);
            if (result)
                return Results.Ok("Transactions complete");
            return Results.Conflict("Cannot create transactions");
        }
        catch (FormatException)
        {
            return Results.BadRequest(
                "Dormitory constants not set or have bad value");
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