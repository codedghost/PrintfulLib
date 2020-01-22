using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class CardInfo
    {
        /// <summary>
        /// Payment Card Type
        /// </summary>
        [JsonProperty("type")]
        public string CardType { get; set; }

        /// <summary>
        /// Masked card number with only last 4 digits visible
        /// </summary>
        [JsonProperty("number_masked")]
        public string MaskedCardNumber { get; set; }

        /// <summary>
        /// Card Expiry Date
        /// </summary>
        [JsonProperty("expiry")]
        public string ExpiryDate { get; set; }
    }
}