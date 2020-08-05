using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class ItemOption
    {
        [JsonProperty("id")]
        public string OptionId { get; set; }

        [JsonProperty("value")]
        public string OptionValue { get; set; }
    }
}