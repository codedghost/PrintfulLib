using System;
using Newtonsoft.Json;
using PrintfulLib.Converters;
using PrintfulLib.Helpers;

namespace PrintfulLib.Models.ChildObjects
{
    public class Order
    {
        [JsonProperty("id")]
        public int? OrderId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("store")]
        public int? StoreId { get; set; }

        [JsonProperty("status")]
        private string _status { get; set; }
        public OrderStatus OrderStatus => OrderStatusHelper.ParseOrderStatus(_status);

        [JsonProperty("shipping")]
        public string ShippingMethod { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("updated")]
        [JsonConverter(typeof(TimestampDateTimeConverter))]
        public DateTime Updated { get; set; }

        [JsonProperty("recipient")]
        public Address RecipientAddress { get; set; }

        [JsonProperty("items")]
        public Item[] OrderItems { get; set; }

        [JsonProperty("incomplete_items")]
        public IncompleteItem[] IncompleteItems { get; set; }

        [JsonProperty("costs")]
        public Costs Costs { get; set; }

        [JsonProperty("retail_costs")]
        public Costs RetailCosts { get; set; }

        [JsonProperty("pricing_breakdown")]
        public object[] PricingBreakdown { get; set; }

        [JsonProperty("shipments")]
        public Shipment[] Shipments { get; set; }

        [JsonProperty("gift")]
        public GiftData GiftData { get; set; }

        [JsonProperty("packing_slip")]
        public OrderPackingSlip OrderPackingSlip { get; set; }
    }
}