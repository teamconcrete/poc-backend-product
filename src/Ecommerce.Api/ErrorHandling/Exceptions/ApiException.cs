using Ecommerce.Domain.Enums;
using System;

namespace Ecommerce.Api.ErrorHandling.Exceptions
{
    public class ApiException : Exception
    {
        public ApiException(ApiDetailedErrorCodes errorCode)
        {
            ErrorCode = errorCode;
        }

        public ApiDetailedErrorCodes ErrorCode { get; set; }
    }
}
