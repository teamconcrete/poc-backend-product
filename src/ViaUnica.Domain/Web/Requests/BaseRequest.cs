namespace ViaUnica.Domain.Web.Requests
{
    public abstract class BaseRequest<T>
    {
        public abstract T ConvertToModel();
    }
}
