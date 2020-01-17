using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Interfaces.ExternalClients;
using PrintfulLib.Models.ApiResponse;
using PrintfulLib.Services;

namespace PrintfulLib.ExternalClients
{
    public class PrintfulClient : IPrintfulClient
    {
        private ProductService _productService;
        private CountryService _countryService;
        private ShippingService _shippingService;
        private TaxesService _taxesService;

        public PrintfulClient(string apiKey)
        {
            _productService = new ProductService(apiKey);
            _countryService = new CountryService(apiKey);
            _shippingService = new ShippingService(apiKey);
            _taxesService = new TaxesService(apiKey);
        }

        public async Task<List<GetSyncVariantsResult>> GetAllProductsWithVariants()
        {
            var result = await _printfulApiClient.GetAsync("store/products");

            if (!result.IsSuccessStatusCode) return null;

            var jsonString = await result.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<GetSyncProductsResult>(jsonString);

            return await GetAllVariants(data);
        }

        public async Task<List<GetSyncVariantsResult>> GetRelevantProductsWithVariants(string searchTerm)
        {
            var result = await _printfulApiClient.GetAsync($"store/products?search={WebUtility.UrlEncode(searchTerm)}");

            if (!result.IsSuccessStatusCode) return null;

            var data = JsonConvert.DeserializeObject<GetSyncProductsResult>(await result.Content.ReadAsStringAsync());

            return await GetAllVariants(data);
        }

        public async Task<GetSyncVariantsResult> GetVariantsById(int id)
        {
            return await GetVariants(id);
        }

        private async Task<GetSyncVariantsResult> GetVariants(int id)
        {
            var result = await _printfulApiClient.GetAsync($"store/products/{id}");
            if (!result.IsSuccessStatusCode) return null;

            var jsonString = await result.Content.ReadAsStringAsync();

            var syncVariantsResult = JsonConvert.DeserializeObject<GetSyncVariantsResult>(jsonString);

            return syncVariantsResult;
        }

        private async Task<List<GetSyncVariantsResult>> GetAllVariants(GetSyncProductsResult getSyncProductsResult)
        {
            List<GetSyncVariantsResult> results = new List<GetSyncVariantsResult>();

            // Now go get the product images and other info
            foreach (var item in getSyncProductsResult.Result)
            {
                var variant = await GetVariants(item.Id);

                if (variant == null) continue;

                results.Add(variant);
            }

            return results;
        }
    }
}