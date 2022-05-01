﻿using System.Text;
using System.Text.Json;
using DMS.Models;
using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DMS.Controllers;

[ApiController]
[Authorize]
[Route("/api/[controller]")]
public class ResidentsController : ControllerBase
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
        return Results.Ok(_resource.GetAllResidents());
    }

    [HttpPost]
    public async Task<IResult> AddResident()
    {
        Resident? resident = null;
        StreamReader? reader = null;
        try
        {
            reader = new StreamReader(Request.Body);
            var message = await reader.ReadToEndAsync();
            resident =
                System.Text.Json.JsonSerializer.Deserialize<Resident>(message);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information, e.ToString());
        }
        finally
        {
            reader?.Close();
        }

        if (resident is null)
            return Results.BadRequest("Wrong JSON format");

        var addResult = _resource.AddResident(resident);

        if (!addResult.Item1)
        {
            return Results.Conflict(addResult.Item2);
        }

        return Results.Ok("Added successfully");
    }


    [HttpGet]
    [Route("/api/[controller]/{id:int}")]
    public IResult GetResidentById(int id)
    {
        var res = _resource.GetResidentById(id);
        if (res is null)
            return Results.BadRequest("Wrong id");

        return Results.Ok(res);
    }

    [HttpPut]
    [Route("/api/[controller]")]
    public async Task<IResult> UpdateResidentInfo()
    {
        Resident? resident = null;
        StreamReader? reader = null;
        try
        {
            reader = new StreamReader(Request.Body);
            var message = await reader.ReadToEndAsync();
            resident =
                System.Text.Json.JsonSerializer.Deserialize<Resident>(message);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information, e.ToString());
        }
        finally
        {
            reader?.Close();
        }

        if (resident is null)
            return Results.BadRequest("Wrong JSON format");

        var updateResult = _resource.UpdateResident(resident);

        if (!updateResult.Item1)
            return Results.Conflict(updateResult.Item2);

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