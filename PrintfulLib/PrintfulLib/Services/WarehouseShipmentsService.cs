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
        private HttpClient _client;

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
                await _client.GetAsync(
                    $"warehouse/shipments?offset={request.Offset}&limit={request.Limit}{filterQueryString}");

            if (!apiResponse.IsSuccessStatusCode)
                throw new Exception(
                    $"Api responded with status code: {apiResponse.StatusCode}. Reason: {apiResponse.ReasonPhrase}");

            var jsonString = await apiResponse.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<GetWarehouseShipmentsResponse>(jsonString);

            return data;
        }

        public async Task<GetWarehouseShipmentDataResponse> GetWarehouseShipmentData(
            GetWarehouseShipmentDataRequest request)
        {
            if (request == null || request.WarehouseShipmentId == 0)
                throw new Exception("No data provided to request");

            var apiResponse = await _client.GetAsync($"warehouse/shipments/{request.WarehouseShipmentId}");

            if (!apiResponse.IsSuccessStatusCode)
                throw new Exception($"Api responded with status code: {apiResponse.StatusCode}. Reason: {apiResponse}");

            var jsonString = await apiResponse.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<GetWarehouseShipmentDataResponse>(jsonString);

            return data;
        }

        public async Task<CreateWarehouseShipmentResponse> CreateWarehouseShipment(
            CreateWarehouseShipmentRequest request)
        {
            if (request == null || request.ShipmentId == 0)
                throw new Exception("No data provided to request");

            var apiResponse = await _client.PostAsync("warehouse/shipments", HttpClientHelper.GetJsonData(request));

            if (!apiResponse.IsSuccessStatusCode)
                throw new Exception(
                    $"Api responded with status code: {apiResponse.StatusCode}. Reason: {apiResponse.ReasonPhrase}");

            var jsonString = await apiResponse.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<CreateWarehouseShipmentResponse>(jsonString);

            return data;
        }
    }
}