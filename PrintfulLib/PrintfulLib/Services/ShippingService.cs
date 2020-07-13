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
        private PrintfulHttpClient _client;

        internal ShippingService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }

        internal async Task<CalculateShippingRatesResponse> CalculateShippingRates(ShippingRequest request)
        {
            var apiResponse =
                await _client.PostAsync<CalculateShippingRatesResponse, ShippingRequest>("shipping/rates", request);

            return apiResponse;
        }
    }
}