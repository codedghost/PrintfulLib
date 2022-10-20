using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiRequest.Taxes
{
    public class TaxRequest
    {
        [JsonProperty("recipient")]
        public TaxAddressInfo Recipient { get; set; }
    }
}