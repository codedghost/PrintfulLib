using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.WebhookResponses
{
    public class SyncInfo
    {
        [JsonProperty("sync_product")]
        public SyncProduct ProductInformation { get; set; }
    }
}