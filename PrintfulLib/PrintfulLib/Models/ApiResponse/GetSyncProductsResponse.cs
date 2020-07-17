using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetSyncProductsResponse: PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public SyncProduct[] Result { get; set; }

        [JsonProperty("paging")]
        public ApiPaging Paging { get; set; }
    }
}
