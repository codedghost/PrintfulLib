using PrintfulLib.Models.Data;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetSyncProductsResult
    {
        public int Code { get; set; }
        public SyncProduct[] Result { get; set; }
        public ApiPaging Paging { get; set; }
    }
}
