using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Services
{
    public class WarehouseProductsService
    {
        private readonly HttpClient _client;

        public WarehouseProductsService(string apiKey)
        { 
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }

        public async Task<GetWarehouseProductsResponse> GetWarehouseProducts(GetWarehouseProductsRequest request)
        {
            if (request == null || request.Limit == 0)
                throw new Exception("No data provided to request");
            if (request.Limit > 100)
                throw new Exception($"Maximum number of items per page is 100");

            var apiResponse = await _client.GetAsync($"warehouse/products?offset={request.Offset}&limit={request.Limit}");

            if (!apiResponse.IsSuccessStatusCode)
                throw new Exception(
                    $"Api responded with status code: {apiResponse.StatusCode}. Reason: {apiResponse.ReasonPhrase}");

            var jsonString = await apiResponse.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<GetWarehouseProductsResponse>(jsonString);

            return data;
        }
    }
}