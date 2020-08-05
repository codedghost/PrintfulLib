using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class CancelOrderResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public Order CancelledOrder { get; set; }
    }
}