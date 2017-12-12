using Ecommerce.Data.MongoDB;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces.Repository;
using MongoDB.Driver;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data
{
    public class ConfigurationRepository : MongoRepository<Configuration>, IConfigurationRepository
    {
        public ConfigurationRepository(IMongoWrapper mongo) : base(mongo, "configuration")
        {
        }
    }
}
