using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetCountryListResponse
    {
        /// <summary>
        /// Response status code
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("result")] 
        public Country[] Countries { get; set; }
    }
}