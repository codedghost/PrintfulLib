using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiResponse.Order
{
    public class UpdateOrderDataResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public ChildObjects.Order Order{ get; set; }
    }
}