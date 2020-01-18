using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Services
{
    internal class ShippingService
    {
        private HttpClient _client;

        internal ShippingService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }

        internal async Task<CalculateShippingRatesResponse> CalculateShippingRates(ShippingRequest request)
        {
            var apiResponse = await _client.PostAsync("shipping/rates", HttpClientHelper.GetJsonData(request));

            if (!apiResponse.IsSuccessStatusCode)
                return null;

            var jsonString = await apiResponse.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<CalculateShippingRatesResponse>(jsonString);

            return data;
        }
    }
}