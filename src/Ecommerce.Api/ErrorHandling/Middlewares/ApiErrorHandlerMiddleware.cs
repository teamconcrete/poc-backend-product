using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Ecommerce.Api.ErrorHandling.Models;
using Ecommerce.Api.ErrorHandling.Exceptions;
using Ecommerce.Core.Extensions;
using Ecommerce.Domain.Enums;
using System;
using System.Threading.Tasks;

namespace Ecommerce.Api.ErrorHandling.Middlewares
{
    public class ApiErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;        
        private bool _showErrorDetails;

        public ApiErrorHandlerMiddleware(RequestDelegate next, bool showErrorDetails)
        {
            _next = next;
            _showErrorDetails = showErrorDetails;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ApiException ex)
            {
                ConfigureErrorResponse(context);
                await context.Response.WriteAsync(GetError(ex.Message, ex.ErrorCode));
            }
            catch (Exception ex)
            {
                ConfigureErrorResponse(context);
                await context.Response.WriteAsync(GetError(ex.Message, ApiDetailedErrorCodes.Generic));
            }
        }

        private void ConfigureErrorResponse(HttpContext context)
        {
            var requestPath = context.Request.Path;

            context.Response.StatusCode = 500;
            context.Response.Headers.Clear();

        }

        private string GetError(string exceptionMessage, ApiDetailedErrorCodes errorCode)
        {
            if (!_showErrorDetails)
                exceptionMessage = errorCode.GetDescriptionValue();
            
            var result = JsonConvert.SerializeObject(new ApiError((int)errorCode, errorCode.GetNameValue(), exceptionMessage));
            
            return result;
        }
    }
}
