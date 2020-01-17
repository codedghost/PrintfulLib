using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiRequest
{
    public class ShippingRequest
    {
        [JsonProperty("recipient")]
        [JsonRequired]
        public AddressInfo RecipientAddressInfo { get; set; }

        [JsonProperty("items")]
        [JsonRequired]
        public ItemInfo[] Items { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}