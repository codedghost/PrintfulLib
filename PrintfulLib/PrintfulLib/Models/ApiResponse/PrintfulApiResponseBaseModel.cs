using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiResponse
{
    public class PrintfulApiResponseBaseModel
    {
        /// <summary>
        /// Response status code
        /// </summary>
        [JsonProperty("code")]
        public int StatusCode { get; set; }
    }
}