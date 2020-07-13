using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Services
{
    public class WarehouseShipmentsService
    {
        private PrintfulHttpClient _client;

        public WarehouseShipmentsService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }

        public async Task<GetWarehouseShipmentsResponse> GetWarehouseShipments(GetWarehouseShipmentsRequest request)
        {
            if (request == null || request.Limit == 0)
                throw new Exception("No data provided to request");
            if (request.Limit > 100)
                throw new Exception("Maximum number of items per page is 100");

            var filterQueryString = string.IsNullOrWhiteSpace(request.FilterStatus)
                ? string.Empty
                : $"&status={request.FilterStatus}";

            var apiResponse =
                await _client.GetAsync<GetWarehouseShipmentsResponse>(
                    $"warehouse/shipments?offset={request.Offset}&limit={request.Limit}{filterQueryString}");

            return apiResponse;
        }

        public async Task<GetWarehouseShipmentDataResponse> GetWarehouseShipmentData(
            GetWarehouseShipmentDataRequest request)
        {
            if (request == null || request.WarehouseShipmentId == 0)
                throw new Exception("No data provided to request");

            var apiResponse = await _client.GetAsync<GetWarehouseShipmentDataResponse>($"warehouse/shipments/{request.WarehouseShipmentId}");

            return apiResponse;
        }

        public async Task<CreateWarehouseShipmentResponse> CreateWarehouseShipment(
            CreateWarehouseShipmentRequest request)
        {
            if (request == null || request.ShipmentId == 0)
                throw new Exception("No data provided to request");

            var apiResponse = await _client.PostAsync<CreateWarehouseShipmentResponse, CreateWarehouseShipmentRequest>("warehouse/shipments", request);

            return apiResponse;
        }
    }
}