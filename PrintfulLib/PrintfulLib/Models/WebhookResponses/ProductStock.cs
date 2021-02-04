using Newtonsoft.Json;

namespace PrintfulLib.Models.WebhookResponses
{
    public class ProductStock : IWebhookDataObject
    {
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("variant_stock")]
        public VariantStock VariantStock { get; set; }
    }
}