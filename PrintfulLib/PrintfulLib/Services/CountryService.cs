using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Services
{
    internal class CountryService
    {
        private readonly PrintfulHttpClient _client;

        internal CountryService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }

        internal async Task<GetCountryListResponse> GetCountryList()
        {
            var apiResponse = await _client.GetAsync<GetCountryListResponse>("countries");

            return apiResponse;
        }
    }
}