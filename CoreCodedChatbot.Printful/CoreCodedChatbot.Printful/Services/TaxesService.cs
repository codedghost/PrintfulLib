using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Services
{
    internal class TaxesService
    {
        private readonly HttpClient _client;

        internal TaxesService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }

        internal async Task<GetRequiredTaxStatesResponse> GetRequiredTaxStates()
        {
            var apiResponse = await _client.GetAsync("tax/countries");

            if (!apiResponse.IsSuccessStatusCode) return null;

            var jsonString = await apiResponse.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<GetRequiredTaxStatesResponse>(jsonString);

            return data;
        }

        public async Task<CalculateTaxRateResponse> CalculateTaxRate(TaxRequest taxRequest)
        {
            var apiResponse = await _client.PostAsync("tax/rates", HttpClientHelper.GetJsonData(taxRequest));

            if (!apiResponse.IsSuccessStatusCode) return null;

            var jsonString = await apiResponse.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<CalculateTaxRateResponse>(jsonString);

            return data;
        }
    }
}