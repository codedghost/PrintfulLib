﻿using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse
{
    public class GetSyncVariantInformationResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")] 
        public SyncVariantInfo SyncVariantInfo { get; set; }
    }
}