using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly ApplicationContext _context;

        public MyTestController(ILogger<MyTestController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Resident> Get()
        {
            foreach (var resident in _context.Residents)
            {
                _logger.Log(LogLevel.Information, resident.ToString());
            }
            return _context.Residents.OrderBy(r => r.ResidentId);
        }
    }
}