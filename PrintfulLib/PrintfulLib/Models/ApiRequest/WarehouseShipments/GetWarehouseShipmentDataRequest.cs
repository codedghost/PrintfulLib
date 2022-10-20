using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiRequest.WarehouseShipments
{
    public class GetWarehouseShipmentDataRequest
    {
        [JsonProperty("id")]
        public int? WarehouseShipmentId { get; set; }
    }
}