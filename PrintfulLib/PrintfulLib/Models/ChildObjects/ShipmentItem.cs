using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class ShipmentItem
    {
        [JsonProperty("item_id")]
        public int? LineItemId { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("picked")] 
        public int? Picked { get; set; }

        [JsonProperty("printed")]
        public int? Printed { get; set; }

        [JsonProperty("is_started")]
        public bool IsStarted { get; set; }
    }
}