using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class PutRequestVariant : RequestVariant
    {
        [JsonProperty("id")]
        public int VariantId { get; set; }
    }
}