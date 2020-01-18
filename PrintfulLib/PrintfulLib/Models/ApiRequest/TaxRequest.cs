using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiRequest
{
    public class TaxRequest
    {
        [JsonProperty("recipient")]
        public TaxAddressInfo Recipient { get; set; }
    }
}