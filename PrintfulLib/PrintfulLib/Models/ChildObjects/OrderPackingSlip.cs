using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class OrderPackingSlip : PackingSlip
    {
        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }
    }
}