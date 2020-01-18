using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PrintfulLib.Models.ChildObjects
{
    /// <summary>
    /// Item Information class.
    /// One of VariantId, ExternalVariantId or WarehouseProductVariantId must be populated
    /// </summary>
    public class ItemInfo
    {
        [JsonProperty("variant_id")]
        public string VariantId { get; set; }

        [JsonProperty("external_variant_id")]
        public string ExternalVariantId { get; set; }

        [JsonProperty("warehouse_product_variant_id")]
        public string WarehouseProductVariantId { get; set; }

        [JsonProperty("quantity")]
        [JsonRequired]
        public int Quantity { get; set; }

        [JsonProperty("value")]
        public string ItemValue { get; set; }
    }
}