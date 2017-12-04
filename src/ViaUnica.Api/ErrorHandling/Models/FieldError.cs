namespace ViaUnica.Api.ErrorHandling.Models
{
    public class FieldError
    {
        public FieldError()
        {

        }

        public FieldError(string field, string message)
        {
            Field = field;
            Message = message;
        }

        public string Field { get; set; }

        public string Message { get; set; }
    }
}
