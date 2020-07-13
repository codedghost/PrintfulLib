﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;

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
            if ((request?.ProductId ?? 0) == 0)
                throw new Exception("No data provided to API");

            var apiResponse =
                await _client.GetAsync<GetProductAndVariantsResponse>($"store/products/{request.ProductId}");

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