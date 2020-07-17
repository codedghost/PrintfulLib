using System;
using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetStoreInformationResponse: PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public StoreData StoreData { get; set; }
    }
}