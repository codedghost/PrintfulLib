using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Services
{
    public class WarehouseProductsService
    {
        private readonly PrintfulHttpClient _client;

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

            var apiResponse = await _client.GetAsync<GetWarehouseProductsResponse>($"warehouse/products?offset={request.Offset}&limit={request.Limit}");

            return apiResponse;
        }

        public async Task<GetWarehouseProductDataResponse> GetWarehouseProductData(
            GetWarehouseProductDataRequest request)
        {
            if (request == null || request.WarehouseProductId == 0)
                throw new Exception("No data provided to request");

            var apiResponse =
                await _client.GetAsync<GetWarehouseProductDataResponse>(
                    $"warehouse/products/{request.WarehouseProductId}");

            return apiResponse;
        }

        public async Task<CreateWarehouseProductResponse> CreateWarehouseProduct(CreateWarehouseProductRequest request)
        {
            if (request?.WarehouseProduct == null)
                throw new Exception("No data provided to create a Warehouse Product");

            if (!request.AcceptTermsAndConditions)
                throw new Exception("Terms and Conditions must be accepted");

            var apiResponse = await _client.PostAsync<CreateWarehouseProductResponse, CreateWarehouseProductRequest>("warehouse/products", request);

            return apiResponse;
        }
    }
}