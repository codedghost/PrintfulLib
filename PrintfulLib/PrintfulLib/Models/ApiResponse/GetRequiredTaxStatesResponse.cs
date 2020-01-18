using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetRequiredTaxStatesResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("result")]
        public Country[] Result { get; set; }
    }
}