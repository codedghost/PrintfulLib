using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class FileType
    {
        [JsonProperty("id")]
        public string FileTypeId { get; set; }

        [JsonProperty("type")]
        public string FileTypeIdentifier { get; set; }

        [JsonProperty("title")]
        public string DisplayName { get; set; }

        [JsonProperty("additional_price")]
        public string AdditionalPrice { get; set; }
    }
}