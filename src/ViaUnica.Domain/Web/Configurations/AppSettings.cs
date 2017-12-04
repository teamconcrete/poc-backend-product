using System.Collections.Generic;

namespace ViaUnica.Domain.Web.Configurations
{
    public class AppSettings
    {
        public MongoConfiguration MongoConfiguration { get; set; }

        public bool ShowErrorDetails { get; set; }
    }
}
