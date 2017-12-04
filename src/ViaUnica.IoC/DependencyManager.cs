using Microsoft.Extensions.DependencyInjection;
using ViaUnica.Domain.Web.Configurations;
using ViaUnica.IoC.Resolvers;

namespace ViaUnica.IoC
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
