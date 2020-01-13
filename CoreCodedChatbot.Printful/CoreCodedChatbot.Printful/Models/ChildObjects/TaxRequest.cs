using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class TaxRequest
    {
        [JsonProperty("recipient")]
        public TaxAddressInfo Recipient { get; set; }
    }
}