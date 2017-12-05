using Ecommerce.Data.MongoDB;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces.Repository;
using MongoDB.Driver;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data
{
    public class ProductRepository : MongoRepository<Product>, IProductRepository
    {
        public ProductRepository(IMongoWrapper mongo) : base(mongo, "product")
        {
        }

        public async Task<Product> GetByProductnameAsync(string productname)
        {
            var collection = GetDefaultCollection();
            var filter = Builders<Product>.Filter.Eq("Productname", productname);
            var result = (await collection.Find(filter).ToListAsync()).FirstOrDefault();

            return result;
        }
    }
}
