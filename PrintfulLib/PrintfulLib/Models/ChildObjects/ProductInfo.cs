using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class ProductInfo
    {
        [JsonProperty("product")]
        public Product Product { get; set; }

        [JsonProperty("variants")]
        public Variant Variant { get; set; }
    }
}