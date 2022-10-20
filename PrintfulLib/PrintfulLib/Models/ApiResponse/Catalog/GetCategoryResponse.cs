using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.Catalog
{
    public class GetCategoryResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public Category Category { get; set; }
    }
}