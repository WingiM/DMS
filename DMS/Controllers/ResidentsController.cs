﻿using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Authorize]
[Route("/api/[controller]")]
public class ResidentsController : MyBaseController
{
    private readonly ILogger<ResidentsController> _logger;
    private readonly ResidentResource _resource;

    public ResidentsController(ILogger<ResidentsController> logger,
        ResidentResource resource)
    {
        _logger = logger;
        _resource = resource;
    }

    [HttpGet]
    public IResult GetAllResidents()
    {
        DateTime resultDate = ParseDate(Request.Headers["date"]);

        return Results.Ok(
            _resource.GetAllResidents(resultDate).Select(ConvertResident)
        );
    }

    [HttpPost]
    public async Task<IResult> AddResident()
    {
        var data = await ParseRequestBody();

        if (data is null)
            return Results.BadRequest("Error parsing request body");
        
        var addResult = _resource.AddResident(data);

        if (!addResult.Item1)
        {
            Response.StatusCode = 409;
            return Results.Conflict(addResult.Item2);
        }
            
        return Results.Ok("Added successfully");
    }

    [HttpGet]
    [Route("/api/[controller]/{id:int}")]
    public IResult GetResidentById(int id)
    {
        DateTime resultDate = ParseDate(Request.Headers["date"]);

        var res = _resource.GetResidentById(id, resultDate);
        if (res is null)
            return Results.BadRequest("Wrong id");

        return Results.Ok(ConvertResident(res));
    }

    [HttpPut]
    [Route("/api/[controller]/{id:int}")]
    public async Task<IResult> UpdateResidentInfo(int id)
    {
        var data = await ParseRequestBody();

        if (data is null)
            return Results.BadRequest("Error parsing request body");

        var updateResult = _resource.UpdateResident(id, data);

        if (!updateResult.Item1)
        {
            Response.StatusCode = 409;
            return Results.Conflict(updateResult.Item2);
        }
        
        return Results.Ok("Updated successfully");
    }

    [HttpDelete]
    [Route("/api/[controller]/{id:int}")]
    public IResult DeleteResident(int id)
    {
        var res = _resource.DeleteResident(id);
        if (!res)
            return Results.BadRequest("Wrong resident id");

        return Results.Ok("Deleted successfully");
    }
}