using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MandsStoreAPI
{
    /// <summary>
    /// Provides access to the M&amp;S Store API.
    /// </summary>
    public class MandsStoreApiClient
    {
        readonly string ApiKey;
        readonly string SecretKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="MandsStoreApiClient"/> class with the given API keys.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="secretKey">The API secret key.</param>
        /// <exception cref="ArgumentNullException"><paramref name="apiKey"/> is <b>null</b>.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="secretKey"/> is <b>null</b>.</exception>
        public MandsStoreApiClient(string apiKey, string secretKey)
        {
            if (apiKey == null) throw new ArgumentNullException("apiKey");
            if (secretKey == null) throw new ArgumentNullException("secretKey");
            this.ApiKey = apiKey;
            this.SecretKey = secretKey;
        }

        string AuthorizationString
        {
            get { return string.Format("MSAuth apikey={0},secretkey={1}", ApiKey, SecretKey); }
        }

        async Task<string> GetRawStoreInfo(string storeId)
        {
            if (string.IsNullOrWhiteSpace(storeId))
                throw new ArgumentNullException("storeId");
            using (var client = new HttpClient()) {
                var req = new HttpRequestMessage {
                    RequestUri = new Uri("https://api.marksandspencer.com/v1/stores/" + storeId),
                    Method = HttpMethod.Get
                };
                req.Headers.Add("accept", "application/json");
                req.Headers.Add("Authorization", AuthorizationString);
                var response = await client.SendAsync(req).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode)
                    throw new InvalidOperationException(response.ReasonPhrase);
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Asynchronously retrieves store information from the API.
        /// </summary>
        /// <param name="storeId">The ID of the store to retrieve.</param>
        /// <returns>A <see cref="StoreInfo"/> object containing information about the store.</returns>
        public async Task<StoreInfo> GetStoreInfo(string storeId)
        {
            var rawResponse = await GetRawStoreInfo(storeId).ConfigureAwait(false);
            return JsonConvert.DeserializeObject<StoreInfo>(rawResponse);
        }
    }
}
