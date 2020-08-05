using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class GiftData
    {
        [JsonProperty("subject")]
        public string Title { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}