using System.ComponentModel;
using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class WarehouseShipment
    {
        [JsonProperty("id")]
        public int? ShipmentId { get; set; }
        [JsonProperty("location")]
        public string WarehouseLocation { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
        [JsonProperty("carrier")]
        public string DeliveryCarrier { get; set; }
        [JsonProperty("items")]
        public WarehouseShipmentItem[] WarehouseShipmentItem { get; set; }
    }
}