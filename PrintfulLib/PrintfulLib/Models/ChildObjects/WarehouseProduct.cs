using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class WarehouseProduct
    {
        [JsonProperty("id")]
        public int? ProductId { get; set; }

        [JsonProperty("name")]
        public string ProductName { get; set; }

        [JsonProperty("status")]
        public string ProductStatus { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("retail_price")]
        public float RetailPrice { get; set; }

        [JsonProperty("variants")]
        public WarehouseProductVariant[] ProductVariants { get; set; }
    }
}