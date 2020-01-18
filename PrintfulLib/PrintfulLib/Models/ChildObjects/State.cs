using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class State
    {
        /// <summary>
        /// State Code - Mandatory when creating an order for USA, Canada and Australia
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// State name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}