using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class FileOption
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}