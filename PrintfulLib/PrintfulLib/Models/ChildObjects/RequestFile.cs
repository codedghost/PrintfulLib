using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class RequestFile
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int FileId { get; set; }

        [JsonProperty("url")]
        public string FileUrl { get; set; }

        [JsonProperty("options")]
        public FileOption[] FileOptions { get; set; }
    }
}