using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiRequest.WarehouseProducts
{
    public class GetWarehouseProductDataRequest
    {
        [JsonProperty("id")]
        public int? WarehouseProductId { get; set; }
    }
}