using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiRequest
{
    public class CreateNewProductRequest
    {
        [JsonProperty("sync_product")]
        public RequestProduct RequestProduct { get; set; }

        [JsonProperty("sync_variants")]
        public RequestVariant[] RequestVariants { get; set; }
    }
}