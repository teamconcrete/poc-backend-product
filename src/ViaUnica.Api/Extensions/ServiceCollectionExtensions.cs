using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using ViaUnica.Domain.Web.Configurations;

namespace ViaUnica.Api.Extensions
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
