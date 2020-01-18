using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetSyncVariantsResponse
    {
        public int Code { get; set; }
        public VariantQueryResult Result { get; set; }
    }
}