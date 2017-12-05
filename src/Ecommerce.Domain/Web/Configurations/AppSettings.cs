using System.Collections.Generic;

namespace Ecommerce.Domain.Web.Configurations
{
    public class AppSettings
    {
        public MongoConfiguration MongoConfiguration { get; set; }

        public bool ShowErrorDetails { get; set; }
    }
}
