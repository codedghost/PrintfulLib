using System;
using System.Linq;
using System.Threading.Tasks;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiRequest.Product;
using PrintfulLib.Models.ApiResponse.Product;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Services
{
    internal class ProductService : PrintfulServiceBase
    {
        internal ProductService(string apiKey) : base(apiKey)
        {
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
                $"store/products?category_id={request.CategoryId}&limit={request.Limit}&offset={request.Offset}{statusString}{searchString}");

            return apiResponse;
        }

        internal async Task<GetProductAndVariantsResponse> GetProductAndVariants(GetProductAndVariantsRequest request)
        {
            if (request == null)
                throw new Exception("No data provided to API");

            var idString = PrintfulIdHelper.GetIdOrExternalId(request.ProductId, request.ExternalId);

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

            var idString = PrintfulIdHelper.GetIdOrExternalId(request.ProductId, request.ExternalId);

            var apiResponse = await _client.DeleteAsync<DeleteProductResponse>($"store/products/{idString}");

            return apiResponse;
        }

        internal async Task<ModifyProductResponse> ModifyProduct(ModifyProductRequest request)
        {
            if (request == null)
                throw new Exception("No data provided to API");

            var idString = PrintfulIdHelper.GetIdOrExternalId(request.ProductId, request.ExternalId);

            var apiResponse =
                await _client.PutAsync<ModifyProductResponse, PutRequestProductBody>($"store/products/{idString}",
                    request.PutRequestProductBody);

            return apiResponse;
        }

        internal async Task<CreateNewSyncVariantResponse> CreateNewSyncVariant(CreateNewSyncVariantRequest request)
        {
            if (request == null) throw new Exception("No data provided to API");

            var idString = PrintfulIdHelper.GetIdOrExternalId(request.SyncProductId, request.ExternalId);

            var apiResponse =
                await _client.PostAsync<CreateNewSyncVariantResponse, RequestVariant>(
                    $"store/products/{idString}/variants", request.RequestVariant);

            return apiResponse;
        }

        internal async Task<GetSyncVariantInformationResponse> GetSyncVariantInfo(
            GetSyncVariantInformationRequest request)
        {
            if (request == null) throw new Exception("No data provided to API");

            var idString = PrintfulIdHelper.GetIdOrExternalId(request.VariantId, request.ExternalId);

            var apiResponse = await _client.GetAsync<GetSyncVariantInformationResponse>($"store/variants/{idString}");

            return apiResponse;
        }

        internal async Task<DeleteSyncVariantResponse> DeleteSyncVariant(DeleteSyncVariantRequest request)
        {
            if (request == null) throw new Exception("No data provided to API");

            var idString = PrintfulIdHelper.GetIdOrExternalId(request.VariantId, request.ExternalId);

            var apiResponse = await _client.DeleteAsync<DeleteSyncVariantResponse>($"/store/variants/{idString}");

            return apiResponse;
        }

        internal async Task<ModifySyncVariantResponse> ModifySyncVariant(ModifySyncVariantRequest request)
        {
            if (request == null) throw new Exception("No data provided to API");

            var idString = PrintfulIdHelper.GetIdOrExternalId(request.VariantId, request.ExternalId);

            var apiResponse =
                await _client.PutAsync<ModifySyncVariantResponse, PutRequestVariant>($"store/variants/{idString}",
                    request.PutRequestVariant);

            return apiResponse;
        }
    }
}