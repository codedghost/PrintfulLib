using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiRequest
{
    public class ModifySyncVariantRequest
    {
        public int VariantId { get; set; }
        public string ExternalId { get; set; }
        public PutRequestVariant PutRequestVariant { get; set; }
    }
}