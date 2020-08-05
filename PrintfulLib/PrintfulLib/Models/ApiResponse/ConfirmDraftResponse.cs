using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class ConfirmDraftResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public Order Order { get; set; }
    }
}