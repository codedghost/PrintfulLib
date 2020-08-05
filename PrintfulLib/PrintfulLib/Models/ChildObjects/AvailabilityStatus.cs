using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class AvailabilityStatus
    {
        [JsonProperty("region")]
        public string RegionCode { get; set; }

        [JsonProperty("status")]
        public string StockStatus { get; set; }
    }
}