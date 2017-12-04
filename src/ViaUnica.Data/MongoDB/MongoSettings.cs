namespace ViaUnica.Data.MongoDB
{
    public class MongoSettings : IMongoSettings
    {
        public MongoSettings(string connectionString, string database)
        {
            ConnectionString = connectionString;
            Database = database;
        }

        public string ConnectionString { get; set; }

        public string Database { get; set; }
    }
}
