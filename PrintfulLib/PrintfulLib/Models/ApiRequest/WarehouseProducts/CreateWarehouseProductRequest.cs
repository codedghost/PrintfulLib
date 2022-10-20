using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiRequest.WarehouseProducts
{
    public class CreateWarehouseProductRequest
    {
        [JsonProperty("product")]
        public WarehouseProduct WarehouseProduct { get; set; }

        [JsonProperty("terms_accepted")]
        public bool AcceptTermsAndConditions { get; set; }
    }
}