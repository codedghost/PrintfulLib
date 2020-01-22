using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class Address
    {
        /// <summary>
        /// Full name
        /// </summary>
        [JsonProperty("name")]
        public string FullName { get; set; }

        /// <summary>
        /// Company Name
        /// </summary>
        [JsonProperty("company")]
        public string CompanyName { get; set; }

        /// <summary>
        /// First line of the Address
        /// </summary>
        [JsonProperty("address1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Second line of the address
        /// </summary>
        [JsonProperty("address2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// State Code
        /// </summary>
        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        /// <summary>
        /// Country Name
        /// </summary>
        [JsonProperty("state_name")]
        public string StateName { get; set; }

        /// <summary>
        /// Country Code
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Country Name
        /// </summary>
        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// ZIP or Postal Code
        /// </summary>
        [JsonProperty("zip")]
        public string ZipOrPostalCode { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        [JsonProperty("phone")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        [JsonProperty("email")]
        public string email { get; set; }
    }
}