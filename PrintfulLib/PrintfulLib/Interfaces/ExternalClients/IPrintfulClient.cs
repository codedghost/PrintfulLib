using System.Collections.Generic;
using System.Threading.Tasks;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Interfaces.ExternalClients
{
    public interface IPrintfulClient
    {
        Task<GetRequiredTaxStatesResponse> GetRequiredTaxStates();
        Task<CalculateTaxRateResponse> CalculateTaxRate(TaxRequest taxRequest);
        Task<CalculateShippingRatesResponse> CalculateShippingRates(ShippingRequest shippingRequest);
        Task<GetCountryListResponse> GetCountryList();
        Task<GetStoreInformationResponse> GetStoreInformation();
        Task<ChangePackingSlipResponse> ChangePackingSlip(ChangePackingSlipRequest request);
        Task<GetWarehouseProductsResponse> GetWarehouseProducts(GetWarehouseProductsRequest request);
        Task<GetWarehouseProductDataResponse> GetWarehouseProductData(GetWarehouseProductDataRequest request);
        Task<CreateWarehouseProductResponse> CreateWarehouseProduct(CreateWarehouseProductRequest request);
        Task<GetWarehouseShipmentsResponse> GetWarehouseShipments(GetWarehouseShipmentsRequest request);

        Task<GetWarehouseShipmentDataResponse> GetWarehouseShipmentData(
            GetWarehouseShipmentDataRequest request);

        Task<CreateWarehouseShipmentResponse> CreateWarehouseShipment(
            CreateWarehouseShipmentRequest request);

        Task<GetFilesResponse> GetFiles(GetFilesRequest request);
        Task<GetFileInformationResponse> GetFileInformation(GetFileInformationRequest request);
        Task<AddFileResponse> AddFile(AddFileRequest request);
        Task<GetSyncProductsResponse> GetProducts(GetProductsRequest request);
        Task<GetProductAndVariantsResponse> GetProductAndVariants(GetProductAndVariantsRequest request);
        Task<CreateNewProductResponse> CreateProduct(CreateNewProductRequest request);
        Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest request);
        Task<ModifyProductResponse> ModifyProduct(ModifyProductRequest request);
        Task<CreateNewSyncVariantResponse> CreateNewSyncVariant(CreateNewSyncVariantRequest request);
        Task<GetSyncVariantInformationResponse> GetSyncVariantInfo(
            GetSyncVariantInformationRequest request);

        Task<DeleteSyncVariantResponse> DeleteSyncVariant(DeleteSyncVariantRequest request);
        Task<ModifySyncVariantResponse> ModifySyncVariant(ModifySyncVariantRequest request);
        Task<GetOrdersResponse> GetOrders(GetOrdersRequest request);
        Task<CreateNewOrderResponse> CreateOrder(CreateNewOrderRequest request);
        Task<EstimateCostsResponse> EstimateCosts(EstimateCostsRequest request);
        Task<GetOrderDataResponse> GetOrder(GetOrderDataRequest request);
        Task<CancelOrderResponse> CancelOrder(CancelOrderRequest request);
        Task<UpdateOrderDataResponse> UpdateOrderData(UpdateOrderDataRequest request);
        Task<ConfirmDraftResponse> ConfirmDraftForFulfillment(ConfirmDraftRequest request);
    }
}