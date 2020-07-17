using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class DeleteProductResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public ProductInfo ProductInfo{ get; set; }
    }
}