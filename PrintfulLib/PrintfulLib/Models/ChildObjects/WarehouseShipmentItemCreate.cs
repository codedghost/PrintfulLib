using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class WarehouseShipmentItemCreate
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("variant_id")]
        public int VariantId { get; set; }
    }
}