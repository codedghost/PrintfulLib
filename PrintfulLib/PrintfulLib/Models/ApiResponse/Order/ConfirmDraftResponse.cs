using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiResponse.Order
{
    public class ConfirmDraftResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public ChildObjects.Order Order { get; set; }
    }
}