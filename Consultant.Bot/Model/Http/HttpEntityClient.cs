using Consultant.Bot.Utility;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Consultant.Bot.Model.Http
{
    public class HttpEntityClient
    {
        private HttpClient Client { get; set; }

        public HttpEntityClient(Uri baseAddress, string privateApiKey)
        {
            Client = new HttpClient()
            {
                BaseAddress = baseAddress,
                DefaultRequestVersion = HttpVersion.Version20,
                Timeout = TimeSpan.FromSeconds(2)
            };

            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(privateApiKey);
        }

        public async Task<T> GetAsync<T>(string endpoint, CancellationToken cancellationToken = default)
        {
            var response = await Client.GetAsync(endpoint, cancellationToken);

            return await GetDataFromResponseAsync<T>(response);
        }

        public async Task<T> PostAsync<T>(string endpoint, FormUrlEncodedContent formData, CancellationToken cancellationToken = default)
        {
            var response = await Client.PostAsync(endpoint, formData, cancellationToken);

            return await GetDataFromResponseAsync<T>(response);
        }

        public async Task<TOut> PostAsJsonAsync<TIn, TOut>(string endpoint, TIn data, CancellationToken cancellationToken = default)
        {
            var response = await Client.PostAsJsonAsync(endpoint, data, JsonUtility.JsonOptions, cancellationToken: cancellationToken);

            return await GetDataFromResponseAsync<TOut>(response);
        }

        private static async Task<T> GetDataFromResponseAsync<T>(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpEntityException(response.StatusCode);
            }

            var json = await response.Content.ReadAsStringAsync();

            return JsonUtility.GetData<T>(json);
        }
    }

    public class HttpEntityException : Exception
    {
        public HttpStatusCode StatusCode { get; }

        public HttpEntityException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }
    }
}
