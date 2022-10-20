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
                if (Type == WebhookEventType.OrderPutOnHold.ToWebhookTypeString()) return WebhookEventType.OrderPutOnHold;
                if (Type == WebhookEventType.OrderRemoveHold.ToWebhookTypeString()) return WebhookEventType.OrderRemoveHold;

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
        public object WebhookDataObject { get; set; }

        [JsonIgnore]
        public IWebhookDataObject WebhookData
        {
            get
            {
                switch (EventType)
                {
                    case WebhookEventType.PackageShipped:
                        return JsonConvert.DeserializeObject<ShipmentInfo>(JsonConvert.SerializeObject(WebhookDataObject));
                    case WebhookEventType.PackageReturned:
                        return JsonConvert.DeserializeObject<ReturnInfo>(JsonConvert.SerializeObject(WebhookDataObject));
                    case WebhookEventType.OrderFailed:
                        return JsonConvert.DeserializeObject<OrderStatusChange>(JsonConvert.SerializeObject(WebhookDataObject));
                    case WebhookEventType.OrderCancelled:
                        return JsonConvert.DeserializeObject<OrderStatusChange>(JsonConvert.SerializeObject(WebhookDataObject));
                    case WebhookEventType.ProductSynced:
                        return JsonConvert.DeserializeObject<SyncInfo>(JsonConvert.SerializeObject(WebhookDataObject));
                    case WebhookEventType.ProductUpdated:
                        return JsonConvert.DeserializeObject<SyncInfo>(JsonConvert.SerializeObject(WebhookDataObject));
                    case WebhookEventType.StockUpdated:
                        return JsonConvert.DeserializeObject<ProductStock>(JsonConvert.SerializeObject(WebhookDataObject));
                    case WebhookEventType.OrderPutOnHold:
                        return JsonConvert.DeserializeObject<OrderStatusChange>(JsonConvert.SerializeObject(WebhookDataObject));
                    case WebhookEventType.OrderRemoveHold:
                        return JsonConvert.DeserializeObject<OrderStatusChange>(JsonConvert.SerializeObject(WebhookDataObject));
                    case WebhookEventType.NotBound:
                        return null;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}