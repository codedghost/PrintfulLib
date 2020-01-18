using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetSyncProductsResponse
    {
        public int Code { get; set; }
        public SyncProduct[] Result { get; set; }
        public ApiPaging Paging { get; set; }
    }
}
