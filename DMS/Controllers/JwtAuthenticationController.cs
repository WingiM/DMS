using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DMS.Controllers
{
    [Route("/api/login")]
    public class JwtAuthenticationController : ControllerBase
    {
        private readonly ILogger<JwtAuthenticationController> _logger;

        public JwtAuthenticationController(
            ILogger<JwtAuthenticationController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IResult Post([FromServices] IConfiguration configuration)
        {
            Request.Headers.TryGetValue("password", out var pass);
            if (pass.Count == 0)
            {
                Response.StatusCode = 400;
                return Results.Json(
                    new { message = "Incorrect password given" },
                    statusCode: 400);
            }

            _logger.Log(LogLevel.Information, pass.First());
            var jwt = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Audience"],
                expires: DateTime.UtcNow.Add(TimeSpan.FromHours(2)),
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                        configuration["Jwt:Key"])),
                    SecurityAlgorithms.HmacSha256)
            );

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            var response = new
            {
                access_token = encodedJwt
            };

            return Results.Ok(response);
        }
    }
}