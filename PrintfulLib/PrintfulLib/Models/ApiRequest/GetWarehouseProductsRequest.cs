using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiRequest
{
    public class GetWarehouseProductsRequest
    {
        public int Offset { get; set; }

        public int Limit { get; set; }
    }
}