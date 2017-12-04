using MongoDB.Driver;

namespace ViaUnica.Data.MongoDB
{
    public interface IMongoWrapper
    {
        IMongoDatabase GetDatabase();
    }
}
