using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class DeleteSyncVariantResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public VariantInfo VariantInfo { get; set; }
    }
}