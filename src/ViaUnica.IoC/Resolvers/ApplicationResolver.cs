using Microsoft.Extensions.DependencyInjection;
using ViaUnica.Application;
using ViaUnica.Application.Interfaces;

namespace ViaUnica.IoC.Resolvers
{
    static class ApplicationResolver
    {
        public static void Setup(IServiceCollection services)
        {
            services.AddScoped<IProductAppService, ProductAppService>();            
        }
    }
}
