using System.Threading.Tasks;
using PrintfulLib.Models.ApiRequest.Product;
using PrintfulLib.Models.ApiResponse.Catalog;
using PrintfulLib.Models.ApiResponse.Country;

namespace PrintfulLib.Services
{
    internal class CatalogService : PrintfulServiceBase
    {
        internal CatalogService(string apiKey) : base(apiKey)
        {
        }

        internal async Task<GetCategoriesResponse> GetCategories()
        {
            var apiResponse = await _client.GetAsync<GetCategoriesResponse>("categories");

            return apiResponse;
        }

        internal async Task<GetCategoryResponse> GetCategory(GetCategoryRequest request)
        {
            var apiResponse = await _client.GetAsync<GetCategoryResponse>($"categories/{request.CategoryId}");

            return apiResponse;
        }
    }
}