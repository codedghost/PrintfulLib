using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiResponse.Order
{
    public class CancelOrderResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public ChildObjects.Order CancelledOrder { get; set; }
    }
}