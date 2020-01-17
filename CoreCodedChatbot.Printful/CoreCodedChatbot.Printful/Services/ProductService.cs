using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Services
{
    internal class ProductService
    {
        private readonly HttpClient _client;

        internal ProductService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }

        internal async Task<GetSyncProductsResult> GetAllProducts()
        {
            var result = await _client.GetAsync("store/products");

            if (!result.IsSuccessStatusCode) return null;

            var jsonString = await result.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<GetSyncProductsResult>(jsonString);

            return data;
        }

    }
}