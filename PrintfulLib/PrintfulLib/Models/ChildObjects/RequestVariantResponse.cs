using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class RequestVariantResponse
    {
        [JsonProperty("id")]
        public int? SyncVariantId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("sync_product_id")]
        public int? PrintfulSyncVariantId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("synced")]
        public bool IsSynced { get; set; }

        [JsonProperty("variant_id")]
        public int? PrintfulVariantId { get; set; }

        [JsonProperty("retail_price")]
        public float RetailPrice { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("product")]
        public ProductMiniInfo Product { get; set; }

        [JsonProperty("files")]
        public File[] Files { get; set; }

        [JsonProperty("options")]
        public ItemOption[] ItemOptions { get; set; }
    }
}