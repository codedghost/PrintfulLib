using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.Product
{
    public class GetSyncVariantInformationResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")] 
        public SyncVariantInfo SyncVariantInfo { get; set; }
    }
}