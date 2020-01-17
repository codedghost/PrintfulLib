using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class CalculateTaxRateResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("result")]
        public TaxInfo Result { get; set; }
    }
}