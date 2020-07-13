using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class Product
    {
        [JsonProperty("id")]
        public int ProductId { get; set; }

        [JsonProperty("type")]
        public string ProductType { get; set; }

        [JsonProperty("type_name")]
        public string ProductTypeName { get; set; }

        [JsonProperty("brand")]
        public string BrandName { get; set; }

        [JsonProperty("model")]
        public string ModelName { get; set; }

        [JsonProperty("image")]
        public string ImageUrl { get; set; }

        [JsonProperty("variant_count")]
        public int VariantTotal { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("files")]
        public FileType[] FileTypes { get; set; }

        [JsonProperty("options")]
        public OptionType[] OptionTypes { get; set; }

        [JsonProperty("is_discontinued")]
        public bool IsDiscontinued { get; set; }

        [JsonProperty("avg_fulfillment_time")]
        public float AverageFulfillmentTime { get; set; }

        [JsonProperty("description")]
        public string ProductDescription { get; set; }
    }
}