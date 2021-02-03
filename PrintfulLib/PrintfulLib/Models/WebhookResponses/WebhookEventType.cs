using System;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace PrintfulLib.Models.WebhookResponses
{
    public enum WebhookEventType
    {
        PackageShipped,
        PackageReturned,
        OrderFailed,
        OrderCancelled,
        ProductSynced,
        ProductUpdated,
        StockUpdated,
        OrderPutOnHold,
        OrderRemoveHold,
        NotBound
    }

    public static class WebhookEventTypeExtensions
    {
        public static string ToString(this WebhookEventType type)
        {
            switch (type)
            {
                case WebhookEventType.PackageShipped:
                    return "package_shipped";
                case WebhookEventType.PackageReturned:
                    return "package_returned";
                case WebhookEventType.OrderFailed:
                    return "order_failed";
                case WebhookEventType.OrderCancelled:
                    return "order_cancelled";
                case WebhookEventType.ProductSynced:
                    return "product_synced";
                case WebhookEventType.ProductUpdated:
                    return "product_updated";
                case WebhookEventType.StockUpdated:
                    return "stock_updated";
                case WebhookEventType.OrderPutOnHold:
                    return "order_put_hold";
                case WebhookEventType.OrderRemoveHold:
                    return "order_remove_hold";
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, "Unrecognised Webhook event type");
            }
        }
    }

}