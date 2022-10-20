using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.Order
{
    public class GetOrdersResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public ChildObjects.Order[] Orders { get; set; }

        [JsonProperty("paging")]
        public ApiPaging Paging { get; set; }
    }
}