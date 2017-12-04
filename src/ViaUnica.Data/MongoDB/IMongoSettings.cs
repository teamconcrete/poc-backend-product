namespace ViaUnica.Data.MongoDB
{
    public interface IMongoSettings
    {
        string ConnectionString { get; set; }

        string Database { get; set; }
    }
}
