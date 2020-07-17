using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetWarehouseProductsResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public WarehouseProduct[] WarehouseProducts { get; set; }

        [JsonProperty("paging")]
        public ApiPaging Paging { get; set; }
    }
}