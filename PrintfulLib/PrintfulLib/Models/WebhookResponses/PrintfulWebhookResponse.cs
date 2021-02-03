using System;
using Newtonsoft.Json;
using PrintfulLib.Converters;

namespace PrintfulLib.Models.WebhookResponses
{
    public class PrintfulWebhookResponse
    {
        public WebhookEventType EventType
        {
            get
            {
                if (Type == WebhookEventType.PackageShipped.ToString()) return WebhookEventType.PackageShipped;
                if (Type == WebhookEventType.PackageReturned.ToString()) return WebhookEventType.PackageReturned;
                if (Type == WebhookEventType.OrderFailed.ToString()) return WebhookEventType.OrderFailed;
                if (Type == WebhookEventType.OrderCancelled.ToString()) return WebhookEventType.OrderCancelled;
                if (Type == WebhookEventType.ProductSynced.ToString()) return WebhookEventType.ProductSynced;
                if (Type == WebhookEventType.ProductUpdated.ToString()) return WebhookEventType.ProductUpdated;
                if (Type == WebhookEventType.StockUpdated.ToString()) return WebhookEventType.StockUpdated;
                if (Type == WebhookEventType.OrderPutOnHold.ToString()) return WebhookEventType.OrderRemoveHold; 
                
                return WebhookEventType.NotBound;
            }
            set
            {
                Type = value.ToString();
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