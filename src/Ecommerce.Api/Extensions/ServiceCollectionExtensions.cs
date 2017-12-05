using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Ecommerce.Domain.Web.Configurations;

namespace Ecommerce.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static T GetInstance<T>(this IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();
            return provider.GetService<T>();
        }

        public static AppSettings GetAppSettings(this IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();
            return provider.GetService<IOptions<AppSettings>>().Value;
        }
    }
}
