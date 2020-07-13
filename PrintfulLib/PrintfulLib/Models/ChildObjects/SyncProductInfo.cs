using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class SyncProductInfo
    {
        [JsonProperty("sync_product")]
        public SyncProduct SyncProduct { get; set; }

        [JsonProperty("sync_variants")]
        public SyncVariant[] SyncVariants { get; set; }
    }
}