namespace PrintfulLib.Models.ApiRequest.Order
{
    public class CancelOrderRequest
    {
        public int OrderId { get; set; }
        public string ExternalId { get; set; }
    }
}