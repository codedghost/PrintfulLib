using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetWarehouseProductDataResponse
    {
        [JsonProperty("code")]
        public int ResponseCode { get; set; }
        [JsonProperty("result")]
        public WarehouseProduct WarehouseProduct { get; set; }
    }
}