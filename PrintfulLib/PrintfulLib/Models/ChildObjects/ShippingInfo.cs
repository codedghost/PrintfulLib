using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class ShippingInfo
    {
        /// <summary>
        /// Shipping Method Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Shipping method name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Shipping rate
        /// </summary>
        [JsonProperty("rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Currency code the shipping rate is returned in
        /// </summary>
        [JsonProperty("currency")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Estimated Minimum Delivery Days. This value is not always returned
        /// </summary>
        [JsonProperty("minDeliveryDays")]
        public int? MinimumDeliveryDays { get; set; }

        /// <summary>
        /// Estimated Maximum Deliver Days. This value is not always returned
        /// </summary>
        [JsonProperty("maxDeliveryDays")]
        public int? MaximumDeliveryDays { get; set; }
    }
}