using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.Catalog
{
    public class GetCategoriesResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public GetCategoriesContainer CategoriesContainer { get; set; }
    }
}