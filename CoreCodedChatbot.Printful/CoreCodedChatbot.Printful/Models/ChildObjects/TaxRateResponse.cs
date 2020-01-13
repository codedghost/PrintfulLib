using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class TaxRateResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("result")]
        public TaxInfo Result { get; set; }
    }
}