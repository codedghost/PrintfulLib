using System;
using Newtonsoft.Json;
using PrintfulLib.Converters;

namespace PrintfulLib.Models.ChildObjects
{
    public class StoreData
    {
        /// <summary>
        /// Store ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Store name
        /// </summary>
        [JsonProperty("name")]
        public string StoreName { get; set; }

        /// <summary>
        /// Store Website URL
        /// </summary>
        [JsonProperty("website")]
        public string StoreWebsiteAddress { get; set; }

        /// <summary>
        /// Custom return address (if enabled)
        /// </summary>
        [JsonProperty("return_address")]
        public Address ReturnAddress { get; set; }

        /// <summary>
        /// summaryText
        /// </summary>
        [JsonProperty("billing_address")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Default payment Currency code
        /// </summary>
        [JsonProperty("currency")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Default payment card (if configured)
        /// </summary>
        [JsonProperty("payment_card")]
        public CardInfo DefaultPaymentCard { get; set; }

        /// <summary>
        /// Packing slip information of the current store
        /// </summary>
        [JsonProperty("packing_slip")]
        public PackingSlip PackingSlipInfo { get; set; }

        /// <summary>
        /// Store type
        /// </summary>
        [JsonProperty("type")]
        public string StoreType { get; set; }

        /// <summary>
        /// Store creation timestamp
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampDateTimeConverter))]
        public DateTime StoreCreatedDateTime { get; set; }
    }
}