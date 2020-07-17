using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class VariantInfo
    {
        [JsonProperty("variant")]
        public Variant Variant { get; set; }

        [JsonProperty("product")]
        public Product Product { get; set; }
    }
}