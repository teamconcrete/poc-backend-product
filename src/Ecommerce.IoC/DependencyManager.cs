using Microsoft.Extensions.DependencyInjection;
using Ecommerce.Domain.Web.Configurations;
using Ecommerce.IoC.Resolvers;

namespace Ecommerce.IoC
{
    public static class DependencyManager
    {
        public static void Setup(this IServiceCollection services, AppSettings appSettings)
        {
            ConfigurationResolver.Setup(services, appSettings);
            ServiceResolver.Setup(services);
            DataResolver.Setup(services, appSettings);
            ExternalServiceResolver.Setup(services);
        }
    }
}
