using ViaUnica.Domain.Enums;
using System;

namespace ViaUnica.Api.ErrorHandling.Exceptions
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
