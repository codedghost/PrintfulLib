using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiResponse.Country
{
    public class GetCountryListResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public ChildObjects.Country[] Countries { get; set; }
    }
}