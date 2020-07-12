using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiRequest
{
    public class GetWarehouseProductsRequest
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}