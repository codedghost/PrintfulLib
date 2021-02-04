using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class WebhookInfo
    {
        [JsonProperty("url")]
        public string WebhookReturnUrl { get; set; }

        [JsonIgnore]
        public List<string> EnabledWebhookEvents
        {
            get => EventTypes.ToList();
            set => EventTypes = value?.ToArray() ?? new string[] { };
        }

        [JsonProperty("types")]
        private string[] EventTypes { get; set; }

        [JsonProperty("params")]
        public object OptionalParams { get; set; }
    }
}