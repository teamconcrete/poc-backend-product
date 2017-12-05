using Microsoft.AspNetCore.Builder;
using Ecommerce.Api.ErrorHandling.Middlewares;

namespace Ecommerce.Api.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseApiErrorHandlerMiddleware(this IApplicationBuilder builder, bool showErrorDetails)
        {
            return builder.UseMiddleware<ApiErrorHandlerMiddleware>(showErrorDetails);
        }
    }
}
