using Microsoft.Extensions.DependencyInjection;
using Ecommerce.Domain.Web.Configurations;
using Ecommerce.IoC.Resolvers;

namespace Ecommerce.IoC
{
    public static class DependencyManager
    {
        public static void Setup(IServiceCollection services, AppSettings appSettings)
        {
            ConfigurationResolver.Setup(services, appSettings);
            ApplicationResolver.Setup(services);
            ServiceResolver.Setup(services);
            DataResolver.Setup(services, appSettings);
        }
    }
}
