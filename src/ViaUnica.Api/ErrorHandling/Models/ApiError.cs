namespace ViaUnica.Api.ErrorHandling.Models
{
    public class ApiError
    {
        public ApiError()
        {

        }

        public ApiError(int errorCode, string message, string description)
        {
            Code = errorCode;
            Message = message;
            Description = description;
        }

        public int Code { get; set; }

        public string Message { get; set; }

        public string Description { get; set; }
    }
}
