using Ecommerce.Domain.ExternalServices;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ecommerce.IoC.Resolvers
{
    static class ExternalServiceResolver
    {
        public static void Setup(IServiceCollection services)
        {
            var settings = new RefitSettings
            {
                JsonSerializerSettings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.Indented,                    
                },
                HttpMessageHandlerFactory = () => new AuthenticatedHttpClientHandler()
            };

            services.AddScoped(typeof(IProductExternalService), (x) =>
            {
                return RestService.For<IProductExternalService>("http://catalogo.api-extra.com.br/v2/ApiLoja/Produto", settings);
            });
        }

        class AuthenticatedHttpClientHandler : HttpClientHandler
        {
            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                if (request.Content != null)
                {
                    var content = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
                    request.Content = new StringContent(content, Encoding.UTF8, "application/json");
                }
                return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
