using MongoDB.Driver;

namespace ViaUnica.Data.MongoDB
{
    public class MongoWrapper : IMongoWrapper
    {
        private IMongoSettings _settings;
        private IMongoClient _client;

        public MongoWrapper(IMongoSettings configuration, IMongoClient client)
        {
            _settings = configuration;
            _client = client;
        }

        public IMongoDatabase GetDatabase()
        {
            var database = _client.GetDatabase(_settings.Database);

            return database;
        }
    }
}
