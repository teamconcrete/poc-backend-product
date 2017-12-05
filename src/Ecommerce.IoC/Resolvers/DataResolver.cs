using Microsoft.Extensions.DependencyInjection;
using Ecommerce.Data;
using Ecommerce.Domain.Interfaces.Repository;
using Ecommerce.Data.MongoDB;
using Ecommerce.Domain.Web.Configurations;
using MongoDB.Driver;

namespace Ecommerce.IoC.Resolvers
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
