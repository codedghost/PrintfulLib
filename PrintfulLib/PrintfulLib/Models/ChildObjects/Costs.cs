using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class Costs
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("subtotal")]
        public string SubTotal { get; set; }

        [JsonProperty("discount")]
        public string Discount { get; set; }

        [JsonProperty("shipping")]
        public string Shipping { get; set; }

        [JsonProperty("digitization")]
        public string Digitization { get; set; }

        [JsonProperty("tax")]
        public string Tax { get; set; }

        [JsonProperty("vat")]
        public string VAT { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }
    }
}