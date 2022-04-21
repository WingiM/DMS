using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers;

[ApiController]
[Route("[controller]")]
public class MyTestController : ControllerBase
{
    private readonly ILogger<MyTestController> _logger;

    public MyTestController(ILogger<MyTestController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = "random msg"
            })
            .ToArray();
    }
}