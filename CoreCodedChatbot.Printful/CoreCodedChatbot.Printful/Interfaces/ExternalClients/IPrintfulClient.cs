using System.Collections.Generic;
using System.Threading.Tasks;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Interfaces.ExternalClients
{
    public interface IPrintfulClient
    {
        Task<GetSyncProductsResponse> GetAllProducts();
        Task<GetSyncProductsResponse> SearchAllProducts(string searchTerm);
        Task<List<GetSyncVariantsResponse>> GetAllProductsWithVariants();
        Task<List<GetSyncVariantsResponse>> SearchAllProductsWithVariants(string searchTerm);
        Task<GetSyncVariantsResponse> GetVariantsById(int id);
        Task<GetRequiredTaxStatesResponse> GetRequiredTaxStates();
        Task<CalculateTaxRateResponse> CalculateTaxRate(TaxRequest taxRequest);
        Task<CalculateShippingRatesResponse> CalculateShippingRates(ShippingRequest shippingRequest);
    }
}