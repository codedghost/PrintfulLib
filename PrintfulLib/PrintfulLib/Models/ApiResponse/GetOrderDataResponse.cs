using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetOrderDataResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public Order Order { get; set; }
    }
}