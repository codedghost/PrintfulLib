using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetWarehouseShipmentsResponse
    {
        [JsonProperty("code")]
        public int StatusCode { get; set; }
        [JsonProperty("result")]
        public WarehouseShipment[] WarehouseShipments { get; set; }

        [JsonProperty("paging")]
        public ApiPaging ApiPaging { get; set; }
    }
}