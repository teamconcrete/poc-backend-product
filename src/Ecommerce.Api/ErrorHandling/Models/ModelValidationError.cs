using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Ecommerce.Api.ErrorHandling.Models
{
    public class ModelValidationError : ApiError
    {
        public ModelValidationError()
        {

        }

        public ModelValidationError(int errorCode, string message, string description) : base(errorCode, message, description)
        {

        }

        public ModelValidationError(int errorCode, string message, string description, ModelStateDictionary modelState) : base(errorCode, message, description)
        {   
            this.Errors = new List<FieldError>();

            modelState.Keys.ToList().ForEach(key =>
            {
                modelState[key].Errors.ToList().ForEach(error =>
                {
                    Errors.Add(new FieldError(key, error.ErrorMessage));
                });
            });
        }

        public List<FieldError> Errors { get; set; }
    }
}
