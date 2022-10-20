using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.Product
{
    public class GetProductAndVariantsResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public SyncProductInfo Result { get; set; }
    }
}