using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Ecommerce.Domain.Entities.Validations;
using Ecommerce.Domain.Interfaces.Validation;
using Ecommerce.Domain.Validation;

namespace Ecommerce.Domain.Entities
{
    [BsonDiscriminator("configuration")]
    public class Configuration : Entity, ISelfValidation
    {
        public string Description { get; set; }

        [JsonIgnore]
        [BsonIgnore]
        public ValidationResult ValidationResult { get; private set; }

        [JsonIgnore]
        [BsonIgnore]
        public bool IsValid
        {
            get
            {
                return true;
            }
        }
    }
}