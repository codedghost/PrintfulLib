using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class Country
    {
        /// <summary>
        /// Country code - Mandatory for all orders
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Country Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Array of States
        /// </summary>
        [JsonProperty("states")] 
        public State[] States { get; set; }
    }
}