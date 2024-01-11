using EdynamicsLog.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace EdynamicsLog.Extensions
{
    public static class AppExtensions
    {
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
