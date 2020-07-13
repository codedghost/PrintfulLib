using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiResponse
{
    public class DeleteProductResponse
    {
        [JsonProperty("code")]
        public int StatusCode { get; set; }

        [JsonProperty("result")]
        public ProductInfo ProductInfo{ get; set; }
    }
}