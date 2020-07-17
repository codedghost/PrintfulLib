using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Services
{
    internal class ProductService
    {
        private readonly PrintfulHttpClient _client;

        internal ProductService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }

        internal async Task<GetSyncProductsResponse> GetProducts(GetProductsRequest request)
        {
            if (request.Limit == 0) request.Limit = 100;
            if (request.Limit > 100)
                throw new Exception("Maximum number of records that can be retrieved is 100");

            var statusString = string.IsNullOrEmpty(request.FilterStatus)
                ? string.Empty
                : $"&status={request.FilterStatus}";
            var searchString = string.IsNullOrEmpty(request.SearchTerms)
                ? string.Empty
                : $"&search={request.SearchTerms}";

            var apiResponse = await _client.GetAsync<GetSyncProductsResponse>(
                $"store/products?limit={request.Limit}&offset={request.Offset}{statusString}{searchString}");

            return apiResponse;
        }

        internal async Task<GetProductAndVariantsResponse> GetProductAndVariants(GetProductAndVariantsRequest request)
        {
            if (request == null)
                throw new Exception("No data provided to API");

            var idString = GetProductIdOrExternalId(request.ProductId, request.ExternalId);

            var apiResponse =
                await _client.GetAsync<GetProductAndVariantsResponse>($"store/products/{idString}");

            return apiResponse;
        }

        internal async Task<CreateNewProductResponse> CreateProduct(CreateNewProductRequest request)
        {
            if (string.IsNullOrWhiteSpace(request?.RequestProduct?.ProductName) ||
                !request.RequestVariants.Any())
                throw new Exception("Must provide a product with product name and at least one variant with variant id and at least one variant file with either id or url");

            var apiResponse =
                await _client.PostAsync<CreateNewProductResponse, CreateNewProductRequest>("store/products", request);

            return apiResponse;
        }

        internal async Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest request)
        {
            if (request == null)
                throw new Exception("No data provided to API");

            var idString = GetProductIdOrExternalId(request.ProductId, request.ExternalId);

            var apiResponse = await _client.DeleteAsync<DeleteProductResponse>($"store/products/{idString}");

            return apiResponse;
        }

        internal async Task<ModifyProductResponse> ModifyProduct(ModifyProductRequest request)
        {
            if (request == null)
                throw new Exception("No data provided to API");

            var idString = GetProductIdOrExternalId(request.ProductId, request.ExternalId);

            var apiResponse =
                await _client.PutAsync<ModifyProductResponse, PutRequestProductBody>($"store/products/{idString}",
                    request.PutRequestProductBody);

            return apiResponse;
        }

        private string GetProductIdOrExternalId(int productId, string externalId)
        {
            if (productId == 0 && string.IsNullOrWhiteSpace(externalId))
                throw new Exception("A ProductID or an ExternalID must be provided");

            var idString = productId > 0 ? productId.ToString() : $"@{externalId}";

            return idString;
        }
    }
}