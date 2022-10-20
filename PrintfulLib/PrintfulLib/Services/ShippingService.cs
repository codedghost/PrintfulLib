using System.Threading.Tasks;
using PrintfulLib.Models.ApiRequest.Shipping;
using PrintfulLib.Models.ApiResponse.Shipping;

namespace PrintfulLib.Services
{
    internal class ShippingService : PrintfulServiceBase
    {
        internal ShippingService(string apiKey) : base(apiKey)
        {
        }

        internal async Task<CalculateShippingRatesResponse> CalculateShippingRates(ShippingRequest request)
        {
            var apiResponse =
                await _client.PostAsync<CalculateShippingRatesResponse, ShippingRequest>("shipping/rates", request);

            return apiResponse;
        }
    }
}