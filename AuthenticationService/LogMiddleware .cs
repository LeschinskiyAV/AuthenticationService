using AuthenticationService;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public class LogMiddleware
{
    private readonly ILogger _logger;
    private readonly RequestDelegate _next;

    public LogMiddleware(RequestDelegate next, ILogger logger)
    {
        _logger = logger;
        _next = next;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        _logger.WriteEvent($"httpContext.Connection.RemoteIpAddress: {httpContext.Connection.RemoteIpAddress}");
        await _next(httpContext);
    }
}