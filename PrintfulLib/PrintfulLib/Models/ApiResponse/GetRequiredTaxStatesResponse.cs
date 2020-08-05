using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetRequiredTaxStatesResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public Country[] Result { get; set; }
    }
}