using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.FileLibrary
{
    public class GetFileInformationResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public File File { get; set; }
    }
}