using Newtonsoft.Json;

namespace PrintfulLib.Models.ApiRequest
{
    public class GetWarehouseShipmentsRequest
    {
        public string FilterStatus { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
    }
}