using Newtonsoft.Json;

namespace PrintfulLib.Models.WebhookResponses
{
    public class VariantStock
    {
        [JsonProperty("out")]
        public int[] VariantsOutOfStock { get; set; }

        [JsonProperty("discontinued")]
        public int[] VariantsDiscontinued { get; set; }
    }
}