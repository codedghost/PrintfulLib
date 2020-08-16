using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class SyncVariant
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("sync_product_id")]
        public int SyncProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("variant_id")]
        public int VariantId { get; set; }

        [JsonProperty("retail_price")]
        public string RetailPrice { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("product")]
        public PrintfulBasicProduct Product { get; set; }

        [JsonProperty("files")]
        public File[] Files { get; set; }

        [JsonProperty("options")]
        public ItemOption[] ItemOptions { get; set; }
    }
}