using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces.Repository;
using Ecommerce.Domain.Interfaces.Service;
using Ecommerce.Domain.Services.Common;

namespace Ecommerce.Domain.Services
{
    public class ConfigurationService : ServiceAsync<Configuration>, IConfigurationService
    {
        public ConfigurationService(IConfigurationRepository repository) : base(repository)
        {
        }
    }
}

