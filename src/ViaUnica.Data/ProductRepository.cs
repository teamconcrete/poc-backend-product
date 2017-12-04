using ViaUnica.Data.MongoDB;
using ViaUnica.Domain.Entities;
using ViaUnica.Domain.Interfaces.Repository;
using MongoDB.Driver;
using System.Linq;
using System.Threading.Tasks;

namespace ViaUnica.Data
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
