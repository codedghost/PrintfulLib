using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class TaxInfo
    {
        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("rate")]
        public float Rate { get; set; }
    }
}