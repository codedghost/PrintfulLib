using PrintfulLib.Models.Data;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetSyncVariantsResult
    {
        public int Code { get; set; }
        public VariantQueryResult Result { get; set; }
    }
}