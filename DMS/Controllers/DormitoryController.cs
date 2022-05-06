using DMS.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Route("api/stats")]
[Authorize]
public class DormitoryController : ControllerBase
{
    private readonly ILogger<DormitoryController> _logger;
    private readonly DormitoryResource _resource;

    public DormitoryController(ILogger<DormitoryController> logger,
        DormitoryResource resource)
    {
        _logger = logger;
        _resource = resource;
    }

    [HttpGet]
    public IResult GetConstants()
    {
        return Results.Ok(_resource.GetConstants());
    }

    [HttpPost]
    public async Task<IResult> SetConstants()
    {
        Dictionary<string, string?>? result = null;
        StreamReader? reader = null;
        try
        {
            reader = new StreamReader(Request.Body);
            var message = await reader.ReadToEndAsync();
            result =
                System.Text.Json.JsonSerializer
                    .Deserialize<Dictionary<string, string?>>(message);
        }
        catch (Exception e)
        {
            _logger.Log(LogLevel.Information, e.ToString());
        }
        finally
        {
            reader?.Close();
        }

        if (result is null)
            return Results.BadRequest("Wrong JSON format");

        _resource.SetConstants(result);
        return Results.Ok("Setting completed");
    }
}