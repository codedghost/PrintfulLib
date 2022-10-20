using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.Product
{
    public class CreateNewSyncVariantResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public RequestVariantResponse RequestVariantResponse { get; set; }
    }
}