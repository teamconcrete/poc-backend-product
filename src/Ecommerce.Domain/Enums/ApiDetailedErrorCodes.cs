using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Enums
{
    public enum ApiDetailedErrorCodes
    {
        //General Errors - 100X
        [Display(Name = "Generic Error", Description = "There was an unexpected error on the application")]
        Generic = -1000,

        [Display(Name = "Invalid request", Description = "Invalid request")]
        InvalidRequest = -1001,

        //Authentication Errors - 200X
        [Display(Name = "Invalid productname or password", Description = "Invalid productname or password")]
        InvalidProductnameOrPassword = -2000,

        [Display(Name = "Invalid refresh token", Description = "Refresh token is invalid or expired, login with password to get a new refresh token")]
        InvalidRefreshToken = -2001,

        [Display(Name = "Invalid guest", Description = "You are trying to get to many tokens in a small interval")]
        InvalidGuest = -2002,

        [Display(Name = "Invalid grant_type", Description = "Invalid value for grant_type")]
        InvalidGrantType = -2003,

        //Validation Errors - 300X
        [Display(Name = "Model validation failed", Description = "There are errors on the request model")]
        ModelValidationFailed = -3000,

        //Infrastructure Errors - 400X
        [Display(Name = "Database error", Description = "There was an unexpected database error")]
        DatabaseError = -4000
    }
}
