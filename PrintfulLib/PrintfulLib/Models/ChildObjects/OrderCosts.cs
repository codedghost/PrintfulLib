using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class OrderCosts
    {
        [JsonProperty("costs")]
        public Costs PrintfulPrices { get; set; }

        [JsonProperty("retail_costs")]
        public Costs RetailCosts { get; set; }
    }
}