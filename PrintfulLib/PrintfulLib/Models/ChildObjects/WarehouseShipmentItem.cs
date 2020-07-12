using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class WarehouseShipmentItem
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("variant")]
        public WarehouseProductVariant WarehouseProductVariant { get; set; }
    }
}