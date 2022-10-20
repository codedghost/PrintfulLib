using System.Threading.Tasks;
using PrintfulLib.Models.ApiResponse.Country;

namespace PrintfulLib.Services
{
    internal class CountryService : PrintfulServiceBase
    {
        internal CountryService(string apiKey) : base(apiKey)
        {
        }

        internal async Task<GetCountryListResponse> GetCountryList()
        {
            var apiResponse = await _client.GetAsync<GetCountryListResponse>("countries");

            return apiResponse;
        }
    }
}