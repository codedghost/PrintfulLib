using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.WarehouseShipments
{
    public class CreateWarehouseShipmentResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public WarehouseShipment WarehouseShipment { get; set; }
    }
}