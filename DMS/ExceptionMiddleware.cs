using DMS.Core.Exceptions;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace DMS;

public class ExceptionMiddleware
{
    public readonly RequestDelegate Next;
    private readonly ILogger<ExceptionMiddleware> _logger;

    public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
    {
        Next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await Next(context);
        }
        catch (DataException ex)
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            await context.Response.WriteAsJsonAsync(new { ex.Message });
        }
        catch (DbUpdateException e)
        {
            if (e.InnerException is PostgresException pe)
            {
                await context.Response.WriteAsJsonAsync(new { pe.MessageText });
            }
            else
            {
                await context.Response.WriteAsJsonAsync(new { Message = "Internal database error" });
            }
        }
        catch (Exception e)
        {
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            _logger.Log(LogLevel.Information, e.ToString());
            await context.Response.WriteAsJsonAsync(new { Message = e.Message });
        }
    }
}