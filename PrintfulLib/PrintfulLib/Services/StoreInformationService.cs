using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
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
    }
}