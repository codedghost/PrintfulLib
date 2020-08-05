using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class CreateNewOrderResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public Order Order { get; set; }
    }
}