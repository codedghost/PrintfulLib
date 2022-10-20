using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiRequest.WarehouseShipments
{
    public class CreateWarehouseShipmentRequest
    {
        [JsonProperty("id")]
        public int? ShipmentId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("items")]
        public WarehouseShipmentItemCreate[] WarehouseShipmentItemCreate { get; set; }
    }
}