using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class CalculateShippingRatesResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public ShippingInfo[] ShippingOptions { get; set; }
    }
}