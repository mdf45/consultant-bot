using Consultant.Bot.Model.Http;
using Consultant.Shared.Entity.Api;
using System.Configuration;

namespace Consultant.Bot.Model
{
    public static class Api
    {
        private static HttpEntityClient Client { get; set; }

        static Api()
        {
            var baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            var privateApiKey = ConfigurationManager.AppSettings["PrivateApiKey"];

            Client = new HttpEntityClient(new Uri(baseUrl), privateApiKey);
        }

        public static async Task<IList<Product>> GetProductsAsync(CancellationToken cancellationToken = default)
        {
            var url = $"{ApiEndpoints.Product}/all";

            return await Client.GetAsync<IList<Product>>(url, cancellationToken);
        }

        public static async Task<IList<Product>> GetProductsByKeywordsAsync(string keywords, CancellationToken cancellationToken = default)
        {
            var url = $"{ApiEndpoints.Product}/find?keywords={keywords}";

            return await Client.GetAsync<IList<Product>>(url, cancellationToken);
        }
    }
}
