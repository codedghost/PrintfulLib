using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class PackingSlip
    {
        /// <summary>
        /// Customer Service email address
        /// </summary>
        [JsonProperty("email")]
        public string CustomerServiceEmailAddress { get; set; }

        /// <summary>
        /// Customer Service Phone number
        /// </summary>
        [JsonProperty("phone")]
        public string CustomerServicePhoneNumber { get; set; }

        /// <summary>
        /// Custom packing slip message
        /// </summary>
        [JsonProperty("message")]
        public string PackingSlipMessage { get; set; }
    }
}