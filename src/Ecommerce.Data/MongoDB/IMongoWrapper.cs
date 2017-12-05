using MongoDB.Driver;

namespace Ecommerce.Data.MongoDB
{
    public interface IMongoWrapper
    {
        IMongoDatabase GetDatabase();
    }
}
