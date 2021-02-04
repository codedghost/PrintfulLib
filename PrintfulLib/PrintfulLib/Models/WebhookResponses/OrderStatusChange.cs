using System.Diagnostics;
using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.WebhookResponses
{
    public class OrderStatusChange : IWebhookDataObject
    {
        [JsonProperty("reason")]
        public string OrderStatusChangeReason { get; set; }

        [JsonProperty("order")]
        public Order Order { get; set; }
    }
}