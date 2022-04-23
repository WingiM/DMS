using System;
using System.Collections.Generic;
using System.Linq;
using DataManipulation;
using DMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DMS.Controllers
{
    [ApiController]
    [Authorize]
    [Route("/api/[controller]")]
    public class MyTestController : ControllerBase
    {
        private readonly ILogger<MyTestController> _logger;
        private readonly ApplicationContext db;

        public MyTestController(ILogger<MyTestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Resident Get()
        {
            _logger.Log(LogLevel.Debug, db.ToString());
            _logger.Log(LogLevel.Debug, db.Residents.ToString());
            return db.Residents.First();
        }
    }
}