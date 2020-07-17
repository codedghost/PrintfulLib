using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class ModifySyncVariantResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public RequestVariantResponse RequestVariantResponse { get; set; }
    }
}