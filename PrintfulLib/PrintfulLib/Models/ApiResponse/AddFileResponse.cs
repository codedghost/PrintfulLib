using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class AddFileResponse: PrintfulApiResponseBaseModel
    {

        [JsonProperty("result")]
        public File File { get; set; }
    }
}