using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class ApiPaging
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}