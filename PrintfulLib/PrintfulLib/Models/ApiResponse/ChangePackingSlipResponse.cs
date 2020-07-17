using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class ChangePackingSlipResponse: PrintfulApiResponseBaseModel
    {
        /// <summary>
        /// New Packing Slip Data
        /// </summary>
        [JsonProperty("result")]
        public PackingSlip PackingSlipData { get; set; }
    }
}