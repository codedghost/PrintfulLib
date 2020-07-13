using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class RequestProduct
    {
        [JsonProperty("external_id")]
        public string ExternalProductId { get; set; }
        [JsonProperty("name")]
        public string ProductName { get; set; }
        [JsonProperty("thumbnail")]
        public string ThumbnailImageUrl { get; set; }
    }
}