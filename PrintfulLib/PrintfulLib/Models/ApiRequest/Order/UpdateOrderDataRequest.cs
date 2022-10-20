using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiRequest.Order
{
    public class UpdateOrderDataRequest
    {
        public int OrderId { get; set; }
        public string ExternalId { get; set; }
        public bool AutoSubmitForFulfillment { get; set; }
        public OrderInput OrderData { get; set; }
    }
}