using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.WebhookResponses
{
    public class CancelInfo
    {
        [JsonProperty("reason")]
        public string CustomerCancelReason { get; set; }

        [JsonProperty("order")]
        public Order Order { get; set; }
    }
}