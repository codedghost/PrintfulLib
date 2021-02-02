using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiRequest
{
    public class GetWarehouseProductDataRequest
    {
        [JsonProperty("id")]
        public int? WarehouseProductId { get; set; }
    }
}