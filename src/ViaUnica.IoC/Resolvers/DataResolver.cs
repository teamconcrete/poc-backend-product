using Microsoft.Extensions.DependencyInjection;
using ViaUnica.Data;
using ViaUnica.Domain.Interfaces.Repository;
using ViaUnica.Data.MongoDB;
using ViaUnica.Domain.Web.Configurations;
using MongoDB.Driver;

namespace ViaUnica.IoC.Resolvers
{
    static class DataResolver
    {
        public static void Setup(IServiceCollection services, AppSettings appSettings)
        {
            var mongoSettings = new MongoSettings(
                appSettings.MongoConfiguration.ConnectionString, appSettings.MongoConfiguration.Database);

            services.AddSingleton(typeof(IMongoSettings), mongoSettings);

            services.AddSingleton(typeof(IMongoClient), new MongoClient(mongoSettings.ConnectionString));

            services.AddSingleton<IMongoWrapper, MongoWrapper>();

            services.AddScoped<IProductRepository, ProductRepository>();            
        }
    }
}
