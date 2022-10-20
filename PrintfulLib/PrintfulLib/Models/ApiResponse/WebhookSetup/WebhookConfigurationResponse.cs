using Newtonsoft.Json;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiResponse.WebhookSetup
{
    public class WebhookConfigurationResponse : PrintfulApiResponseBaseModel
    {
        [JsonProperty("result")]
        public WebhookInfo WebhookInfo { get; set; }
    }
}