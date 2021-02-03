using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Services
{
    internal class TaxesService : PrintfulServiceBase
    {
        internal TaxesService(string apiKey) : base(apiKey)
        {
        }

        internal async Task<GetRequiredTaxStatesResponse> GetRequiredTaxStates()
        {
            var apiResponse = await _client.GetAsync<GetRequiredTaxStatesResponse>("tax/countries");

            return apiResponse;
        }

        internal async Task<CalculateTaxRateResponse> CalculateTaxRate(TaxRequest taxRequest)
        {
            var apiResponse = await _client.PostAsync<CalculateTaxRateResponse, TaxRequest>("tax/rates", taxRequest);

            return apiResponse;
        }
    }
}