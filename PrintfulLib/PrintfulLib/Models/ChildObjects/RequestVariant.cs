using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class RequestVariant
    {
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("variant_id")]
        public int? PrintfulVariantId { get; set; }

        [JsonProperty("retail_price")]
        public float RetailPrice { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("files")]
        public RequestFile[] RequestFiles { get; set; }

        [JsonProperty("options")]
        public ItemOption[] ItemOptions { get; set; }
    }
}