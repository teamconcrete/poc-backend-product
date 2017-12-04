using Microsoft.Extensions.DependencyInjection;
using ViaUnica.Domain.Interfaces.Service;
using ViaUnica.Domain.Services;

namespace ViaUnica.IoC.Resolvers
{
    static class ServiceResolver
    {
        public static void Setup(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();            
        }
    }
}
