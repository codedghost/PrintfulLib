using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiRequest
{
    public class GetWarehouseShipmentDataRequest
    {
        [JsonProperty("id")]
        public int? WarehouseShipmentId { get; set; }
    }
}