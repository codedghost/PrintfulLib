using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class CreateWarehouseProductResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public WarehouseProduct WarehouseProduct { get; set; }
    }
}