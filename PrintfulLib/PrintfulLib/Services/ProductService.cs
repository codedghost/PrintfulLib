using System.Collections.Generic;
using System.Net;
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

        internal async Task<GetSyncProductsResponse> GetAllProducts()
        {
            var result = await _client.GetAsync("store/products");

            if (!result.IsSuccessStatusCode) return null;

            var jsonString = await result.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<GetSyncProductsResponse>(jsonString);

            return data;
        }

        internal async Task<GetSyncProductsResponse> SearchAllProducts(string searchTerm)
        {
            var result = await _client.GetAsync($"store/products?search={WebUtility.UrlEncode(searchTerm)}");

            if (!result.IsSuccessStatusCode) return null;

            var jsonString = await result.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<GetSyncProductsResponse>(jsonString);

            return data;
        }


        internal async Task<List<GetSyncVariantsResponse>> GetAllVariants(GetSyncProductsResponse getSyncProductsResponse)
        {
            List<GetSyncVariantsResponse> results = new List<GetSyncVariantsResponse>();

            // Now go get the product images and other info
            foreach (var item in getSyncProductsResponse.Result)
            {
                var variant = await GetVariants(item.Id);

                if (variant == null) continue;

                results.Add(variant);
            }

            return results;
        }

        private async Task<GetSyncVariantsResponse> GetVariants(int id)
        {
            var result = await _client.GetAsync($"store/products/{id}");

            if (!result.IsSuccessStatusCode) return null;

            var jsonString = await result.Content.ReadAsStringAsync();

            var syncVariantsResult = JsonConvert.DeserializeObject<GetSyncVariantsResponse>(jsonString);

            return syncVariantsResult;
        }

        internal async Task<GetSyncVariantsResponse> GetAllVariantsForProduct(int id)
        {
            return await GetVariants(id);
        }
    }
}