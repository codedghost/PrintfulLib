using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.Product
{
    public class ModifyProductResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public RequestProductResponse RequestProductResponse { get; set; }
    }
}