using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetCountryListResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")] 
        public Country[] Countries { get; set; }
    }
}