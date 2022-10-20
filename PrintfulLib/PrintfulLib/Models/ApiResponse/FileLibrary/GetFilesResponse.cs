using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.FileLibrary
{
    public class GetFilesResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public File[] Files { get; set; }

        [JsonProperty("paging")]
        public ApiPaging ApiPaging { get; set; }
    }
}