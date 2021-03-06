﻿using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class ModifyProductResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public RequestProductResponse RequestProductResponse { get; set; }
    }
}