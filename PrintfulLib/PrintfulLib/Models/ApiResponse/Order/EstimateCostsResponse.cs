using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.Order
{
    public class EstimateCostsResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public OrderCosts OrderCosts { get; set; }
    }
}