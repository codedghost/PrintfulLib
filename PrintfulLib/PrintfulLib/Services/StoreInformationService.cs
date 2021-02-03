using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Services
{
    internal class StoreInformationService : PrintfulServiceBase
    {
        internal StoreInformationService(string apiKey) : base(apiKey)
        {
        }


        internal async Task<GetStoreInformationResponse> GetStoreInformation()
        {
            var apiResponse = await _client.GetAsync<GetStoreInformationResponse>("store");

            return apiResponse;
        }

        internal async Task<ChangePackingSlipResponse> ChangePackingSlip(ChangePackingSlipRequest request)
        {
            var apiResponse =
                await _client.PostAsync<ChangePackingSlipResponse, PackingSlip>("store/packing-slip", 
                    request.PackingSlip);

            return apiResponse;
        }
    }
}