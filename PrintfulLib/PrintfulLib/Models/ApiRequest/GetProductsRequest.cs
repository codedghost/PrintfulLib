namespace PrintfulLib.Models.ApiRequest
{
    public class GetProductsRequest
    {
        public string FilterStatus { get; set; }
        public string SearchTerms { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
    }
}