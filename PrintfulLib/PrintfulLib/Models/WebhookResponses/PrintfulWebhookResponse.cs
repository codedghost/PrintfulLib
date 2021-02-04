using System;
using Newtonsoft.Json;
using PrintfulLib.Converters;

namespace PrintfulLib.Models.WebhookResponses
{
    public class PrintfulWebhookResponse
    {
        [JsonIgnore]
        public WebhookEventType EventType
        {
            get
            {
                if (Type == WebhookEventType.PackageShipped.ToWebhookTypeString()) return WebhookEventType.PackageShipped;
                if (Type == WebhookEventType.PackageReturned.ToWebhookTypeString()) return WebhookEventType.PackageReturned;
                if (Type == WebhookEventType.OrderFailed.ToWebhookTypeString()) return WebhookEventType.OrderFailed;
                if (Type == WebhookEventType.OrderCancelled.ToWebhookTypeString()) return WebhookEventType.OrderCancelled;
                if (Type == WebhookEventType.ProductSynced.ToWebhookTypeString()) return WebhookEventType.ProductSynced;
                if (Type == WebhookEventType.ProductUpdated.ToWebhookTypeString()) return WebhookEventType.ProductUpdated;
                if (Type == WebhookEventType.StockUpdated.ToWebhookTypeString()) return WebhookEventType.StockUpdated;
                if (Type == WebhookEventType.OrderPutOnHold.ToWebhookTypeString()) return WebhookEventType.OrderRemoveHold; 
                
                return WebhookEventType.NotBound;
            }
            set
            {
                Type = value.ToWebhookTypeString();
            }
        }

        [JsonProperty("type")]
        private string Type { get; set; }

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