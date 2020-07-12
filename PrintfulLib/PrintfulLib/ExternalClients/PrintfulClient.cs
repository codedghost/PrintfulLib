using System.Collections.Generic;
using System.Threading.Tasks;
using PrintfulLib.Interfaces.ExternalClients;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;
using PrintfulLib.Services;

namespace PrintfulLib.ExternalClients
{
    public class PrintfulClient : IPrintfulClient
    {
        private ProductService _productService;
        private CountryService _countryService;
        private ShippingService _shippingService;
        private TaxesService _taxesService;
        private StoreInformationService _storeInformationService;
        private WarehouseProductsService _warehouseProductsService;
        private WarehouseShipmentsService _warehouseShipmentsService;
        private FileLibraryService _fileLibraryService;

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
        }

        public async Task<GetSyncProductsResponse> GetAllProducts()
        {
            var products = await _productService.GetAllProducts();

            return products;
        }

        public async Task<GetSyncProductsResponse> SearchAllProducts(string searchTerm)
        {
            var products = await _productService.SearchAllProducts(searchTerm);

            return products;
        }

        public async Task<List<GetSyncVariantsResponse>> GetAllProductsWithVariants()
        {
            var products = await _productService.GetAllProducts();

            if (products == null)
                return new List<GetSyncVariantsResponse>();

            var productsWithVariants = await _productService.GetAllVariants(products);

            return productsWithVariants;
        }

        public async Task<List<GetSyncVariantsResponse>> SearchAllProductsWithVariants(string searchTerm)
        {
            var products = await _productService.SearchAllProducts(searchTerm);

            if (products == null)
                return new List<GetSyncVariantsResponse>();

            var productsWithVariants = await _productService.GetAllVariants(products);

            return productsWithVariants;
        }

        public async Task<GetSyncVariantsResponse> GetVariantsById(int id)
        {
            var getSyncVariantsResponse = await _productService.GetAllVariantsForProduct(id);

            return getSyncVariantsResponse;
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
    }
}