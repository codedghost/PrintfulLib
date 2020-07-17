using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class SyncVariantInfo
    {
        [JsonProperty("sync_variant")]
        public SyncVariant SyncVariant { get; set; }

        [JsonProperty("sync_product")]
        public SyncProduct SyncProduct { get; set; }
    }
}