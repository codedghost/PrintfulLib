using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class WarehouseProductVariant
    {
        [JsonProperty("id")]
        public int VariantId { get; set; }

        [JsonProperty("name")] 
        public string VariantName { get; set; }

        [JsonProperty("sku")]
        public string VariantSku { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("retail_property")]
        public float RetailPrice { get; set; }

        [JsonProperty("quantity")]
        public int QuantityInStock { get; set; }

        [JsonProperty("length")]
        public float Length { get; set; }

        [JsonProperty("width")]
        public float Width { get; set; }

        [JsonProperty("height")]
        public float Height { get; set; }

        [JsonProperty("weight")]
        public float Weight { get; set; }
    }
}