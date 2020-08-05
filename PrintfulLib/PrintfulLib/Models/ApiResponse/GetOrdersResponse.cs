using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetOrdersResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public Order[] Orders { get; set; }

        [JsonProperty("paging")]
        public ApiPaging Paging { get; set; }
    }
}