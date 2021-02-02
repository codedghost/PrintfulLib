using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class IncompleteItem
    {
        [JsonProperty("name")]
        public string ItemName { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("sync_variant_id")]
        public int? SyncVariantId { get; set; }

        [JsonProperty("external_variant_id")]
        public string ExternalVariantId { get; set; }

        [JsonProperty("external_line_item_id")]
        public string ExternalLineItemId { get; set; }
    }
}