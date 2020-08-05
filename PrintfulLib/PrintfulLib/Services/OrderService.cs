using System;
using System.Threading.Tasks;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Services
{
    internal class OrderService
    {

        private readonly PrintfulHttpClient _client;

        internal OrderService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }

        internal async Task<GetOrdersResponse> GetOrders(GetOrdersRequest request)
        {
            if (request == null)
                throw new Exception("No data provided to API");
            if (request.Limit == 0) request.Limit = 100;
            if (request.Limit > 100)
                throw new Exception("Maximum number of records that can be retrieved is 100");

            var statusString = request.OrderStatus == OrderStatus.NoFilter
                ? string.Empty
                : $"&status={request.OrderStatus.GetOrderStatus()}";

            var apiResponse =
                await _client.GetAsync<GetOrdersResponse>(
                    $"orders?offset={request.Offset}&limit={request.Limit}{statusString}");

            return apiResponse;
        }

        internal async Task<CreateNewOrderResponse> CreateOrder(CreateNewOrderRequest request)
        {
            if (request == null)
                throw new Exception("No data provided to API");

            var anyQueryString = (request.AutoSubmitForFulfillment || request.UpdateExisting) ? "?" : string.Empty;

            var confirmString = request.AutoSubmitForFulfillment ? "confirm=1" : string.Empty;
            var updateExistingString = request.UpdateExisting ? "update_existing=1" : string.Empty;

            var joinerString = (request.AutoSubmitForFulfillment && request.UpdateExisting) ? "&" : string.Empty;

            var apiResponse = await _client.PostAsync<CreateNewOrderResponse, OrderInput>(
                $"orders{anyQueryString}{confirmString}{joinerString}{updateExistingString}", request.OrderData);

            return apiResponse;
        }

        internal async Task<EstimateCostsResponse> EstimateCosts(EstimateCostsRequest request)
        {
            if (request == null)
                throw new Exception("No data provided to API");

            var apiResponse =
                await _client.PostAsync<EstimateCostsResponse, OrderInput>("orders/estimate-costs", request.OrderInput);

            return apiResponse;
        }

        internal async Task<GetOrderDataResponse> GetOrder(GetOrderDataRequest request)
        {
            if (request == null)
                throw new Exception("No data provided to API");

            var idString = PrintfulIdHelper.GetIdOrExternalId(request.OrderId, request.ExternalId);

            var apiResponse = await _client.GetAsync<GetOrderDataResponse>($"orders/{idString}");

            return apiResponse;
        }

        internal async Task<CancelOrderResponse> CancelOrder(CancelOrderRequest request)
        {
            if (request == null)
                throw new Exception("No data provided to API");

            var idString = PrintfulIdHelper.GetIdOrExternalId(request.OrderId, request.ExternalId);

            var apiResponse = await _client.DeleteAsync<CancelOrderResponse>($"orders/{idString}");

            return apiResponse;
        }

        internal async Task<UpdateOrderDataResponse> UpdateOrderData(UpdateOrderDataRequest request)
        {

            if (request == null)
                throw new Exception("No data provided to API");

            var idString = PrintfulIdHelper.GetIdOrExternalId(request.OrderId, request.ExternalId);

            var apiResponse =
                await _client.PutAsync<UpdateOrderDataResponse, OrderInput>($"orders/{idString}", request.OrderData);

            return apiResponse;
        }

        internal async Task<ConfirmDraftResponse> ConfirmDraftForFulfillment(ConfirmDraftRequest request)
        {
            if (request == null)
                throw new Exception("No data provided to API");

            var idString = PrintfulIdHelper.GetIdOrExternalId(request.OrderId, request.ExternalId);

            var apiResponse = await _client.PostAsync<ConfirmDraftResponse, object>($"orders/{idString}/confirm", new { });

            return apiResponse;
        }
    }
}