using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class AddressInfo
    {
        [JsonProperty("address1")]
        [JsonRequired]
        public string AddressLine1 { get; set; }

        [JsonProperty("city")] 
        [JsonRequired]
        public string City { get; set; }

        [JsonProperty("country_code")]
        [JsonRequired]
        public string CountryCode { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("zip")] 
        public string ZipOrPostalCode { get; set; }
    }
}