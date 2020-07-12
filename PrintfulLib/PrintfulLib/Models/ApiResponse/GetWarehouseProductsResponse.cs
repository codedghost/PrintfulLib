using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetWarehouseProductsResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("result")]
        public WarehouseProduct[] WarehouseProducts { get; set; }

        [JsonProperty("paging")]
        public ApiPaging Paging { get; set; }
    }
}