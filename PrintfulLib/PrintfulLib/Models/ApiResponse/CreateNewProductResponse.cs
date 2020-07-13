using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class CreateNewProductResponse
    {
        [JsonProperty("code")]
        public int StatusCode { get; set; }
        [JsonProperty("result")]
        public RequestProductResponse RequestProductResponse { get; set; }
    }
}