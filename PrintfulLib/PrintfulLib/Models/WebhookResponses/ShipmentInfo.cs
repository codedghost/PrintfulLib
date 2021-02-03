using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.WebhookResponses
{
    public class ShipmentInfo : IWebhookDataObject
    {
        [JsonProperty("shipment")]
        public Shipment Shipment { get; set; }

        [JsonProperty("order")]
        public Order Order { get; set; }
    }
}