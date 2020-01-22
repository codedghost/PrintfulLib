using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class ChangePackingSlipResponse
    {
        /// <summary>
        /// Response status code
        /// </summary>
        [JsonProperty("code")]
        public int ResponseCode { get; set; }

        /// <summary>
        /// New Packing Slip Data
        /// </summary>
        [JsonProperty("result")]
        public PackingSlip PackingSlipData { get; set; }
    }
}