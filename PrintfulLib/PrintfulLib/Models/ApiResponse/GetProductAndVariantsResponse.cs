using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetProductAndVariantsResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public SyncProductInfo Result { get; set; }
    }
}