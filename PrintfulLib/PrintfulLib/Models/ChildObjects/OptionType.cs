using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class OptionType
    {
        [JsonProperty("id")]
        public string OptionId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string DataType { get; set; }

        [JsonProperty("values")]
        public KeyValuePair<string, object> OptionValues { get; set; }

        [JsonProperty("additional_price")]
        public string AdditionalPrice { get; set; }

        [JsonProperty("additional_price_breakdown")]
        public KeyValuePair<string, object> AdditionalPriceBreakdown { get; set; }
    }
}