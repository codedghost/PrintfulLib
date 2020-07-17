using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetWarehouseProductDataResponse: PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public WarehouseProduct WarehouseProduct { get; set; }
    }
}