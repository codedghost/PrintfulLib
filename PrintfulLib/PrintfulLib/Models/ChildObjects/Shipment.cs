using System;
using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class Shipment
    {
        [JsonProperty("id")]
        public int ShipmentId { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("service")]
        public string DeliveryServiceName { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("tracking_url")]
        public string TrackingUrl { get; set; }

        [JsonProperty("created")]
        public DateTime ShippingTime { get; set; }

        [JsonProperty("ship_date")]
        public string ShipDate { get; set; }

        [JsonProperty("shipped_at")]
        public int ShippingTimeUnixTime { get; set; }

        [JsonProperty("reshipment")]
        public bool Reshipment { get; set; }

        [JsonProperty("items")]
        public ShipmentItem[] ShipmentItems { get; set; }
    }
}