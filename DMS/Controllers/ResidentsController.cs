using System.Globalization;
using DMS.Models;
using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace DMS.Controllers;

[ApiController]
[Authorize]
[Route("/api/[controller]")]
public class ResidentsController : ControllerBase
{
    private static readonly DateTime DefaultDocumentStartDate =
        DateTime.Now.Month >= 9
            ? new DateTime(DateTime.Now.Year, 9, 1)
            : new DateTime(DateTime.Now.Year - 1, 9, 1);


    internal static readonly Func<Resident, DateTime, object> ConvertResident =
        (res, date) => new
        {
            res.ResidentId, res.FirstName, res.LastName, res.Patronymic,
            res.Gender,
            res.BirthDate, res.PassportInformation, res.Tin,
            Rating = res.CountRating(date),
            Debt = res.CountDebt(date), Reports = res.CountReports(date)
        };

    // TODO: parse date from string
    private static DateTime ParseDate(string date)
    {
        if (!DateTime.TryParseExact(date, "u", null, DateTimeStyles.None,
                out var result))
            return DefaultDocumentStartDate;
        return result;
    }

    private void AddResponseProcessedDateHeader(DateTime date)
    {
        Response.Headers.Add("processed-date", date.ToString("u"));
    }

    private readonly ILogger<ResidentsController> _logger;
    private readonly ResidentResource _resource;

    public ResidentsController(ILogger<ResidentsController> logger,
        ResidentResource resource)
    {
        _logger = logger;
        _resource = resource;
    }

    internal static DateTime GetDocumentsDate(StringValues date) =>
        date.Count == 0
            ? DefaultDocumentStartDate
            : ParseDate(date.ElementAt(0));

    [HttpGet]
    public IResult GetAllResidents()
    {
        Request.Headers.TryGetValue("date", out var date);
        var resultDate = GetDocumentsDate(date);
        AddResponseProcessedDateHeader(resultDate);

        return Results.Ok(_resource.GetAllResidents().Select(r =>
            ConvertResident(r, resultDate)));
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
            return Results.Conflict(addResult.Item2);
        return Results.Ok("Added successfully");
    }

    [HttpGet]
    [Route("/api/[controller]/{id:int}")]
    public IResult GetResidentById(int id)
    {
        var res = _resource.GetResidentById(id);
        if (res is null)
            return Results.BadRequest("Wrong id");

        Request.Headers.TryGetValue("date", out var date);
        var resultDate = GetDocumentsDate(date);
        AddResponseProcessedDateHeader(resultDate);

        return Results.Ok(ConvertResident(res, resultDate));
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