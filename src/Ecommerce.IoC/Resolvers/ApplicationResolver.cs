using Microsoft.Extensions.DependencyInjection;
using Ecommerce.Application;
using Ecommerce.Application.Interfaces;

namespace Ecommerce.IoC.Resolvers
{
    static class ApplicationResolver
    {
        public static void Setup(IServiceCollection services)
        {
            services.AddScoped<IProductAppService, ProductAppService>();            
        }
    }
}
