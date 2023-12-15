using Microsoft.AspNetCore.Builder;

public static class LogMiddlewareExtensions
{
    public static IApplicationBuilder UseLogMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<LogMiddleware>();
    }
}