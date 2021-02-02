using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class RequestProductResponse
    {
        [JsonProperty("id")]
        public int? SyncProductId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalSyncProductId { get; set; }

        [JsonProperty("name")]
        public string ProductName { get; set; }

        [JsonProperty("variants")]
        public int? TotalVariants { get; set; }

        [JsonProperty("synced")]
        public int? TotalSynced { get; set; }
    }
}