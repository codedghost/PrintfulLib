using System;
using Newtonsoft.Json;
using PrintfulLib.Converters;

namespace PrintfulLib.Models.ChildObjects
{
    public class Shipment
    {
        [JsonProperty("id")]
        public int? ShipmentId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("service")]
        public string DeliveryServiceName { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("tracking_url")]
        public string TrackingUrl { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampDateTimeConverter))]
        public DateTime ShippingTime { get; set; }

        [JsonProperty("ship_date")]
        public string ShipDate { get; set; }

        [JsonProperty("shipped_at")]
        [JsonConverter(typeof(TimestampDateTimeConverter))]
        public DateTime ShippingTimeUnixTime { get; set; }

        [JsonProperty("reshipment")]
        public bool Reshipment { get; set; }

        [JsonProperty("estimated_delivery_dates")]
        public EstimatedDeliveryDates EstimatedDeliveryDates { get; set; }

        [JsonProperty("items")]
        public ShipmentItem[] ShipmentItems { get; set; }
    }

    public class EstimatedDeliveryDates
    {
        [JsonProperty("from")]
        [JsonConverter(typeof(TimestampDateTimeConverter))]
        public DateTime From { get; set; }

        [JsonProperty("to")]
        [JsonConverter(typeof(TimestampDateTimeConverter))]
        public DateTime To { get; set; }
    }
}