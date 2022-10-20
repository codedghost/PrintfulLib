namespace PrintfulLib.Models.ApiRequest.Product
{
    public class GetProductsRequest
    {
        public int CategoryId { get; set; }
        public string FilterStatus { get; set; }
        public string SearchTerms { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
    }
}