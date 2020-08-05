using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetWarehouseShipmentDataResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public WarehouseShipment WarehouseShipment { get; set; }
    }
}