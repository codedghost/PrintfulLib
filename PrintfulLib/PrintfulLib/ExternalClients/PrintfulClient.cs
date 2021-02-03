using System.Collections.Generic;
using System.Threading.Tasks;
using PrintfulLib.Interfaces.ExternalClients;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;
using PrintfulLib.Models.ChildObjects;
using PrintfulLib.Services;

namespace PrintfulLib.ExternalClients
{
    public class PrintfulClient : IPrintfulClient
    {
        private readonly ProductService _productService;
        private readonly CountryService _countryService;
        private readonly ShippingService _shippingService;
        private readonly TaxesService _taxesService;
        private readonly StoreInformationService _storeInformationService;
        private readonly WarehouseProductsService _warehouseProductsService;
        private readonly WarehouseShipmentsService _warehouseShipmentsService;
        private readonly FileLibraryService _fileLibraryService;
        private readonly OrderService _orderService;
        private readonly WebhookSetupService _webhookSetupService;

        public PrintfulClient(string apiKey)
        {
            _productService = new ProductService(apiKey);
            _countryService = new CountryService(apiKey);
            _shippingService = new ShippingService(apiKey);
            _taxesService = new TaxesService(apiKey);
            _storeInformationService = new StoreInformationService(apiKey);
            _warehouseProductsService = new WarehouseProductsService(apiKey);
            _warehouseShipmentsService = new WarehouseShipmentsService(apiKey);
            _fileLibraryService = new FileLibraryService(apiKey);
            _orderService = new OrderService(apiKey);
            _webhookSetupService = new WebhookSetupService(apiKey);
        }

        public async Task<GetRequiredTaxStatesResponse> GetRequiredTaxStates()
        {
            var getRequiredTaxStatesResponse = await _taxesService.GetRequiredTaxStates();

            return getRequiredTaxStatesResponse;
        }

        public async Task<CalculateTaxRateResponse> CalculateTaxRate(TaxRequest taxRequest)
        {
            var calculateTaxRateResponse = await _taxesService.CalculateTaxRate(taxRequest);

            return calculateTaxRateResponse;
        }

        public async Task<CalculateShippingRatesResponse> CalculateShippingRates(ShippingRequest shippingRequest)
        {
            var calculateShippingRatesResponse = await _shippingService.CalculateShippingRates(shippingRequest);

            return calculateShippingRatesResponse;
        }

        public async Task<GetCountryListResponse> GetCountryList()
        {
            var countryList = await _countryService.GetCountryList();

            return countryList;
        }

        public async Task<GetStoreInformationResponse> GetStoreInformation()
        {
            var storeInformation = await _storeInformationService.GetStoreInformation();

            return storeInformation;
        }

        public async Task<ChangePackingSlipResponse> ChangePackingSlip(ChangePackingSlipRequest request)
        {
            var result = await _storeInformationService.ChangePackingSlip(request);

            return result;
        }

        public async Task<GetWarehouseProductsResponse> GetWarehouseProducts(GetWarehouseProductsRequest request)
        {
            var result = await _warehouseProductsService.GetWarehouseProducts(request);

            return result;
        }

        public async Task<GetWarehouseProductDataResponse> GetWarehouseProductData(GetWarehouseProductDataRequest request)
        {
            var result = await _warehouseProductsService.GetWarehouseProductData(request);

            return result;
        }

        public async Task<CreateWarehouseProductResponse> CreateWarehouseProduct(CreateWarehouseProductRequest request)
        {
            var result = await _warehouseProductsService.CreateWarehouseProduct(request);

            return result;
        }

        public async Task<GetWarehouseShipmentsResponse> GetWarehouseShipments(GetWarehouseShipmentsRequest request)
        {
            var result = await _warehouseShipmentsService.GetWarehouseShipments(request);

            return result;
        }

        public async Task<GetWarehouseShipmentDataResponse> GetWarehouseShipmentData(
            GetWarehouseShipmentDataRequest request)
        {
            var result = await _warehouseShipmentsService.GetWarehouseShipmentData(request);

            return result;
        }

        public async Task<CreateWarehouseShipmentResponse> CreateWarehouseShipment(
            CreateWarehouseShipmentRequest request)
        {
            var result = await _warehouseShipmentsService.CreateWarehouseShipment(request);

            return result;
        }

        public async Task<GetFilesResponse> GetFiles(GetFilesRequest request)
        {
            var result = await _fileLibraryService.GetFiles(request);

            return result;
        }

        public async Task<GetFileInformationResponse> GetFileInformation(GetFileInformationRequest request)
        {
            var result = await _fileLibraryService.GetFileInformation(request);

            return result;
        }

        public async Task<AddFileResponse> AddFile(AddFileRequest request)
        {
            var result = await _fileLibraryService.AddFile(request);

            return result;
        }

        public async Task<GetSyncProductsResponse> GetProducts(GetProductsRequest request)
        {
            var result = await _productService.GetProducts(request);

            return result;
        }

        public async Task<GetProductAndVariantsResponse> GetProductAndVariants(GetProductAndVariantsRequest request)
        {
            var result = await _productService.GetProductAndVariants(request);

            return result;
        }

        public async Task<CreateNewProductResponse> CreateProduct(CreateNewProductRequest request)
        {
            var result = await _productService.CreateProduct(request);

            return result;
        }

        public async Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest request)
        {
            var result = await _productService.DeleteProduct(request);

            return result;
        }

        public async Task<ModifyProductResponse> ModifyProduct(ModifyProductRequest request)
        {
            var result = await _productService.ModifyProduct(request);

            return result;
        }

        public async Task<CreateNewSyncVariantResponse> CreateNewSyncVariant(CreateNewSyncVariantRequest request)
        {
            var result = await _productService.CreateNewSyncVariant(request);

            return result;
        }

        public async Task<GetSyncVariantInformationResponse> GetSyncVariantInfo(GetSyncVariantInformationRequest request)
        {
            var result = await _productService.GetSyncVariantInfo(request);

            return result;
        }

        public async Task<DeleteSyncVariantResponse> DeleteSyncVariant(DeleteSyncVariantRequest request)
        {
            var result = await _productService.DeleteSyncVariant(request);

            return result;
        }

        public async Task<ModifySyncVariantResponse> ModifySyncVariant(ModifySyncVariantRequest request)
        {
            var result = await _productService.ModifySyncVariant(request);

            return result;
        }

        public async Task<GetOrdersResponse> GetOrders(GetOrdersRequest request)
        {
            var result = await _orderService.GetOrders(request);

            return result;
        }

        public async Task<CreateNewOrderResponse> CreateOrder(CreateNewOrderRequest request)
        {
            var result = await _orderService.CreateOrder(request);

            return result;
        }

        public async Task<EstimateCostsResponse> EstimateCosts(EstimateCostsRequest request)
        {
            var result = await _orderService.EstimateCosts(request);

            return result;
        }

        public async Task<GetOrderDataResponse> GetOrder(GetOrderDataRequest request)
        {
            var result = await _orderService.GetOrder(request);

            return result;
        }

        public async Task<CancelOrderResponse> CancelOrder(CancelOrderRequest request)
        {
            var result = await _orderService.CancelOrder(request);

            return result;
        }

        public async Task<UpdateOrderDataResponse> UpdateOrderData(UpdateOrderDataRequest request)
        {
            var result = await _orderService.UpdateOrderData(request);

            return result;
        }

        public async Task<ConfirmDraftResponse> ConfirmDraftForFulfillment(ConfirmDraftRequest request)
        {
            var result = await _orderService.ConfirmDraftForFulfillment(request);

            return result;
        }

        public async Task<WebhookConfigurationResponse> GetWebhookConfiguration()
        {
            var result = await _webhookSetupService.Get();

            return result;
        }

        public async Task<WebhookConfigurationResponse> SetWebhookConfiguration(SetUpWebhookConfigurationRequest request)
        {
            var result = await _webhookSetupService.SetUp(request);

            return result;
        }

        public async Task<WebhookConfigurationResponse> DisableWebhookConfiguration()
        {
            var result = await _webhookSetupService.Disable();

            return result;
        }
    }
}