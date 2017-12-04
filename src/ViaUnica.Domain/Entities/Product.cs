using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using ViaUnica.Domain.Entities.Validations;
using ViaUnica.Domain.Interfaces.Validation;
using ViaUnica.Domain.Validation;

namespace ViaUnica.Domain.Entities
{
    [BsonDiscriminator("product")]
    public class Product : Entity, ISelfValidation
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        [JsonIgnore]
        [BsonIgnore]
        public ValidationResult ValidationResult { get; private set; }

        [JsonIgnore]
        [BsonIgnore]
        public bool IsValid
        {
            get
            {
                var validation = new ProductIsValidValidation();
                ValidationResult = validation.Valid(this);
                return ValidationResult.IsValid;
            }
        }
    }
}