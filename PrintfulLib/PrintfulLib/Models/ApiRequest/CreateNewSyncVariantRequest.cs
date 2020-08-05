using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiRequest
{
    public class CreateNewSyncVariantRequest
    {
        public int SyncProductId { get; set; }
        public string ExternalId { get; set; }

        public RequestVariant RequestVariant { get; set; }
    }
}