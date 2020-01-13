using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class SyncProduct
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("variants")]
        public int Variants { get; set; }

        [JsonProperty("synced")]
        public int Synced { get; set; }
    }
}