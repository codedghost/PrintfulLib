using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Services
{
    internal class StoreInformationService
    {
        private readonly HttpClient _client;

        internal StoreInformationService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }


        internal async Task<GetStoreInformationResponse> GetStoreInformation()
        {
            var apiResponse = await _client.GetAsync("store");

            if (!apiResponse.IsSuccessStatusCode)
                return null;

            var jsonString = await apiResponse.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<GetStoreInformationResponse>(jsonString);

            return data;
        }

        internal async Task<ChangePackingSlipResponse> ChangePackingSlip(ChangePackingSlipRequest request)
        {
            var apiResponse =
                await _client.PostAsync("store/packing-slip", HttpClientHelper.GetJsonData(request.PackingSlip));

            if (!apiResponse.IsSuccessStatusCode)
                return null;

            var jsonString = await apiResponse.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<ChangePackingSlipResponse>(jsonString);

            return data;
        }
    }
}