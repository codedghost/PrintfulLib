using System;
using Newtonsoft.Json;
using PrintfulLib.Converters;
using JsonSerializer = System.Text.Json.JsonSerializer;

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
        public object WebhookData { get; set; }

        [JsonIgnore]
        public IWebhookDataObject WebhookDataObject {
            get
            {
                switch (EventType)
                {
                    case WebhookEventType.PackageShipped:
                        return JsonSerializer.Deserialize<ShipmentInfo>(JsonSerializer.Serialize(WebhookData));
                    case WebhookEventType.PackageReturned:
                        return JsonSerializer.Deserialize<ReturnInfo>(JsonSerializer.Serialize(WebhookData));
                    case WebhookEventType.OrderFailed:
                        return JsonSerializer.Deserialize<OrderStatusChange>(JsonSerializer.Serialize(WebhookData));
                    case WebhookEventType.OrderCancelled:
                        return JsonSerializer.Deserialize<OrderStatusChange>(JsonSerializer.Serialize(WebhookData));
                    case WebhookEventType.ProductSynced:
                        return JsonSerializer.Deserialize<SyncInfo>(JsonSerializer.Serialize(WebhookData));
                    case WebhookEventType.ProductUpdated:
                        return JsonSerializer.Deserialize<SyncInfo>(JsonSerializer.Serialize(WebhookData));
                    case WebhookEventType.StockUpdated:
                        return JsonSerializer.Deserialize<ProductStock>(JsonSerializer.Serialize(WebhookData));
                    case WebhookEventType.OrderPutOnHold:
                        return JsonSerializer.Deserialize<OrderStatusChange>(JsonSerializer.Serialize(WebhookData));
                    case WebhookEventType.OrderRemoveHold:
                        return JsonSerializer.Deserialize<OrderStatusChange>(JsonSerializer.Serialize(WebhookData));
                    case WebhookEventType.NotBound:
                        return null;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}