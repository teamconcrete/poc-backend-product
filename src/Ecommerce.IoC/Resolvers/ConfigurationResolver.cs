using Microsoft.Extensions.DependencyInjection;
using Ecommerce.Domain.Web.Configurations;

namespace Ecommerce.IoC.Resolvers
{
    static class ConfigurationResolver
    {
        public static void Setup(IServiceCollection services, AppSettings appSettings)
        {
        }
    }
}
