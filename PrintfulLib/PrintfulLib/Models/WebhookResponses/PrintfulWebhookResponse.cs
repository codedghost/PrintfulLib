using System;
using Newtonsoft.Json;
using PrintfulLib.Converters;

namespace PrintfulLib.Models.WebhookResponses
{
    public class PrintfulWebhookResponse
    {
        [JsonProperty("type")]
        public string EventType { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("retries")]
        public int NumberOfRetries { get; set; }

        [JsonProperty("store")]
        public int StoreId { get; set; }

        [JsonProperty("data")]
        public IWebhookDataObject WebhookData { get; set; }
    }
}