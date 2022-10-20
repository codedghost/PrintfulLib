namespace PrintfulLib.Models.ApiRequest.WarehouseShipments
{
    public class GetWarehouseShipmentsRequest
    {
        public string FilterStatus { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
    }
}