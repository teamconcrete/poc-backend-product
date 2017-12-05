using Microsoft.Extensions.DependencyInjection;
using Ecommerce.Domain.Interfaces.Service;
using Ecommerce.Domain.Services;

namespace Ecommerce.IoC.Resolvers
{
    static class ServiceResolver
    {
        public static void Setup(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();            
        }
    }
}
