using DMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Controllers
{
    [ApiController]
    [Authorize]
    [Route("/api/[controller]")]
    public class MyTestController : ControllerBase
    {
        private readonly ILogger<MyTestController> _logger;
        private readonly ApplicationContext _context;

        public MyTestController(ILogger<MyTestController> logger,
            ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IResult Get()
        {
            var res = new Resident()
            {
                FirstName = "roma", LastName = "Boma",
                BirthDate = DateTime.UtcNow, Gender = 'M'
            };
            _context.Residents.Add(res);
            _context.SettlementOrders.Add(new SettlementOrder()
            {
                Resident = res, RoomId = "304", OrderDate = DateTime.UtcNow
            });
            _context.SaveChanges();
            return Results.Json(_context.Residents.OrderBy(r => r.ResidentId));
        }
    }
}