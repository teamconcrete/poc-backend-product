using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Ecommerce.Domain.Entities
{
    public class Entity
    {
        [BsonId]
        public Guid Id { get; set; }

        public DateTime LastModified { get; set; }
    }
}
