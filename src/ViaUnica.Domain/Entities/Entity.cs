using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ViaUnica.Domain.Entities
{
    public class Entity
    {
        [BsonId]
        public Guid Id { get; set; }

        public DateTime LastModified { get; set; }
    }
}
