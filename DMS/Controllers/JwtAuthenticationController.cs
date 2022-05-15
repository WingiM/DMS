using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.IdentityModel.Tokens;

namespace DMS.Controllers;

[Route("/api/login")]
public class JwtAuthenticationController : ControllerBase
{
    private readonly IDistributedCache _cache;
    private readonly ILogger<JwtAuthenticationController> _logger;
    private readonly HMACSHA256 _encryptor;
    private readonly IConfiguration _configuration;

    public JwtAuthenticationController(
        ILogger<JwtAuthenticationController> logger,
        IDistributedCache cache, IConfiguration configuration)
    {
        _logger = logger;
        _cache = cache;
        _configuration = configuration;
        _encryptor = new HMACSHA256(
            Encoding.UTF8.GetBytes(configuration["Encryption:AnalogKey"]));
    }

    [HttpPost]
    public IResult GetJwtToken()
    {
        try
        {
            Request.Headers.TryGetValue("password", out var pass);

            var hash = _encryptor.ComputeHash(Encoding.UTF8.GetBytes(pass));
            if (!IsPasswordStored())
            {
                Response.StatusCode = 409;
                return Results.Json(
                    new { message = "Password not set" },
                    statusCode: 409);
            }

            if (!hash.SequenceEqual(_cache.Get("EncryptedPassword")))
            {
                Response.StatusCode = 400;
                return Results.Json(
                    new { message = "Incorrect password given" },
                    statusCode: 400);
            }

            var jwt = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                expires: DateTime.UtcNow.Add(TimeSpan.FromHours(2)),
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                        _configuration["Jwt:Key"])),
                    SecurityAlgorithms.HmacSha256)
            );

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            var response = new
            {
                AccessToken = encodedJwt
            };

            return Results.Ok(response);
        }
        catch (ArgumentNullException)
        {
            return Results.BadRequest("No password given");
        }
    }

    [HttpPost]
    [Route("/api/login/set_password")]
    public IResult SetPassword()
    {
        try
        {
            if (IsPasswordStored())
                return Results.Conflict("Password is already set");
            
            Request.Headers.TryGetValue("password", out var pass);
            Request.Headers.TryGetValue("repeat_password", out var repeatPass);

            if (pass != repeatPass)
            {
                Response.StatusCode = 400;
                return Results.Json(
                    new { message = "Passwords do not match" },
                    statusCode: 400);
            }

            var hash = _encryptor.ComputeHash(Encoding.UTF8.GetBytes(pass));
            _cache.Set("EncryptedPassword", hash);
            return Results.Ok("Password set");
        }
        catch (ArgumentNullException)
        {
            return Results.BadRequest("No password given");
        }
    }

    private bool IsPasswordStored()
    {
        return _cache.Get("EncryptedPassword") is not null;
    }
}