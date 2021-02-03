using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.WebhookResponses
{
    public class ReturnInfo
    {
        [JsonProperty("reason")]
        public string CustomerReturnReason { get; set; }

        [JsonProperty("shipment")]
        public Shipment Shipment { get; set; }

        [JsonProperty("order")]
        public Order Order { get; set; }
    }
}