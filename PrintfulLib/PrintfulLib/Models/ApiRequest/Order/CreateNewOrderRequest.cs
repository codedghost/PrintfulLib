using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiRequest.Order
{
    public class CreateNewOrderRequest
    {
        public OrderInput OrderData { get; set; }
        public bool AutoSubmitForFulfillment { get; set; }
        public bool UpdateExisting { get; set; }
    }
}