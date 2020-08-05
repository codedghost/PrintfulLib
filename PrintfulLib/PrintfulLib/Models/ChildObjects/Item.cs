using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class Item
    {
        [JsonProperty("id")]
        public int LineItemId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("variant_id")]
        public int VariantId { get; set; }

        [JsonProperty("sync_variant_id")]
        public int SyncVariantId { get; set; }

        [JsonProperty("external_variant_id")]
        public string ExternalVariantId { get; set; }

        [JsonProperty("warehouse_product_variant_id")]
        public int WarehouseProductVariantId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("retail_price")]
        public string RetailPrice { get; set; }

        [JsonProperty("name")]
        public string DisplayName { get; set; }

        [JsonProperty("product")]
        public ProductVariant ProductVariant { get; set; }

        [JsonProperty("files")]
        public File[] Files { get; set; }

        [JsonProperty("options")]
        public ItemOption[] ItemOptions { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }
    }
}