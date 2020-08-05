namespace PrintfulLib.Models.ApiRequest
{
    public class CancelOrderRequest
    {
        public int OrderId { get; set; }
        public string ExternalId { get; set; }
    }
}