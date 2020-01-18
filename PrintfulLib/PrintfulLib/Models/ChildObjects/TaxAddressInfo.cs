using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class TaxAddressInfo
    {
        /// <summary>
        /// Country code from printful api
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
        /// <summary>
        /// State Code from printful api
        /// </summary>
        [JsonProperty("state_code")]
        public string StateCode { get; set; }
        /// <summary>
        /// City
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }
        /// <summary>
        /// ZIP or Postal Code
        /// </summary>
        [JsonProperty("zip")]
        public string ZipOrPostCode { get; set; }
    }
}