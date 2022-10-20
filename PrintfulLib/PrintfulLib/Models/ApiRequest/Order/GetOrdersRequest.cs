using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiRequest.Order
{
    public class GetOrdersRequest
    {
        /// <summary>
        /// Optional OrderStatus filter
        /// </summary>
        public OrderStatus OrderStatus { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
    }
}