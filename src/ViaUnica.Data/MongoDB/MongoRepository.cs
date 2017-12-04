using MongoDB.Bson;
using MongoDB.Driver;
using ViaUnica.Domain.Entities;
using ViaUnica.Domain.Interfaces.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViaUnica.Data.MongoDB
{
    public class MongoRepository<T> : IRepositoryAsync<T> where T : Entity
    {
        protected IMongoDatabase _database;
        private string _collectionName;

        public MongoRepository(IMongoWrapper mongo, string collectionName)
        {
            _collectionName = collectionName;
            _database = mongo.GetDatabase();
        }

        protected IMongoCollection<T> GetDefaultCollection()
        {
            return _database.GetCollection<T>(_collectionName);
        }

        public async Task<T> GetAsync(Guid id)
        {
            var collection = GetDefaultCollection();
            var filter = Builders<T>.Filter.Eq("_id", id);
            var result = (await collection.Find(filter).ToListAsync()).FirstOrDefault();

            return result;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var result = new List<T>();
            var collection = GetDefaultCollection();
            var filter = new BsonDocument();

            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;

                    foreach (var document in batch)
                        result.Add(document);
                }
            }

            return result;
        }

        public async Task<IEnumerable<T>> FindAsync(Func<T, bool> predicate)
        {
            var all = await GetAllAsync();
            var result = all.Where(predicate);

            return result;
        }

        public async Task AddAsync(T entity)
        {
            entity.LastModified = DateTime.UtcNow;

            var collection = GetDefaultCollection();
            await collection.InsertOneAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            entity.LastModified = DateTime.UtcNow;

            var collection = GetDefaultCollection();
            var filter = Builders<T>.Filter.Eq("_id", entity.Id);

            await collection.ReplaceOneAsync(filter, entity);
        }

        public async Task DeleteAsync(T entity)
        {
            var collection = GetDefaultCollection();
            var filter = Builders<T>.Filter.Eq("_id", entity.Id);

            await collection.DeleteOneAsync(filter);
        }
    }
}
