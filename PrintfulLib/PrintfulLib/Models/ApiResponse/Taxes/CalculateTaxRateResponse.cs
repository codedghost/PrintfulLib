using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.Taxes
{
    public class CalculateTaxRateResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public TaxInfo Result { get; set; }
    }
}