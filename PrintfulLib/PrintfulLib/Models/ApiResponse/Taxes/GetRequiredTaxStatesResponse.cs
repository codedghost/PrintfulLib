using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiResponse.Taxes
{
    public class GetRequiredTaxStatesResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public ChildObjects.Country[] Result { get; set; }
    }
}