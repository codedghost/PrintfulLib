using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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

        public PrintfulClient(string apiKey)
        {
            _productService = new ProductService(apiKey);
            _countryService = new CountryService(apiKey);
            _shippingService = new ShippingService(apiKey);
            _taxesService = new TaxesService(apiKey);
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
    }
}