using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class Variant
    {
        [JsonProperty("id")]
        public int? VariantId { get; set; }

        [JsonProperty("product_id")]
        public int? ProductId { get; set; }

        [JsonProperty("name")]
        public string DisplayName { get; set; }

        [JsonProperty("size")]
        public string ItemSize { get; set; }

        [JsonProperty("color")]
        public string ItemColour { get; set; }

        [JsonProperty("color_code")]
        public string ColourCode { get; set; }

        [JsonProperty("color_code2")]
        public string ColourCode2 { get; set; }

        [JsonProperty("image")]
        public string ImageUrl { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("in_stock")]
        public bool IsInStock { get; set; }

        [JsonProperty("availability_regions")]
        public object[] AvailabilityRegions { get; set; }

        [JsonProperty("availability_status")]
        public AvailabilityStatus[] AvailabilityStatuses { get; set; }
    }
}