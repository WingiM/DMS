using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DMS_Main.Controllers;

[ApiController]
[Route("[controller]")]
public class ResidentController : Controller
{
    private readonly ILogger<ResidentController> _logger;

    public ResidentController(
        ILogger<ResidentController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public Resident Index(DMSContext db)
    {
        _logger.Log(LogLevel.Information, "RESIDENT CONTROLLER MESSAGE WTF");
        return db.Residents.First(res => res.ResidentId == 1);
    }
}