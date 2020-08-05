using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class OrderInput
    {
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("shipping")]
        public string ShippingMethod { get; set; }

        [JsonProperty("recipient")]
        public Address RecipientAddress { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("retail_costs")]
        public Costs RetailCosts { get; set; }

        [JsonProperty("gift")]
        public GiftData GiftData { get; set; }

        [JsonProperty("packing_slip")]
        public OrderPackingSlip OrderPackingSlip { get; set; }
    }
}