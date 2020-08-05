using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class ShipmentItem
    {
        [JsonProperty("item_id")]
        public int LineItemId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}