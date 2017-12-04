using Microsoft.AspNetCore.Builder;
using ViaUnica.Api.ErrorHandling.Middlewares;

namespace ViaUnica.Api.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseApiErrorHandlerMiddleware(this IApplicationBuilder builder, bool showErrorDetails)
        {
            return builder.UseMiddleware<ApiErrorHandlerMiddleware>(showErrorDetails);
        }
    }
}
