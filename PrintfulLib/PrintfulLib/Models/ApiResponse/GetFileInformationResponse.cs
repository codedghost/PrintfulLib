using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetFileInformationResponse
    {
        [JsonProperty("code")]
        public int StatusCode { get; set; }

        [JsonProperty("result")]
        public File File { get; set; }
    }
}