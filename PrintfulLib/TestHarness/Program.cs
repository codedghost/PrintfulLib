using System;
using System.Linq;
using System.Security.Permissions;
using PrintfulLib.ExternalClients;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiRequest.FileLibrary;
using PrintfulLib.Models.ApiRequest.Order;
using PrintfulLib.Models.ApiRequest.Product;
using PrintfulLib.Models.ApiRequest.Shipping;
using PrintfulLib.Models.ApiRequest.Taxes;
using PrintfulLib.Models.ApiRequest.WarehouseProducts;
using PrintfulLib.Models.ChildObjects;

namespace TestHarness
{
    /// <summary>
    /// This is a test harness used to demonstrate Printful Client usage and to test usage
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // It is recommended to wrap the Client creation in a Factory class for DI purposes
            var client = new PrintfulClient("faubz4qk-z5hy-ajra:4g7e-oe2jc3uk9bj1");

            var keepRunning = true;

            while (keepRunning)
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var storeInfo = client.GetStoreInformation();
                        storeInfo.Wait();

                        var result = storeInfo.Result;
                        Console.WriteLine(result.StoreData.StoreName);
                        break;
                    case "2":
                        var orders = client.GetOrders(new GetOrdersRequest());
                        orders.Wait();

                        var orderResult = orders.Result;

                        foreach (var order in orderResult.Orders)
                        {
                            Console.WriteLine($"Order ID: {order.OrderId}");
                            Console.WriteLine($"OrderDate: {order.Created}");
                            Console.WriteLine($"Shipping Information:");
                            Console.WriteLine($"    Full Name: {order.RecipientAddress.FullName}");
                            Console.WriteLine($"    Line 1: {order.RecipientAddress.AddressLine1}");
                            Console.WriteLine($"    Line 2: {order.RecipientAddress.AddressLine2}");
                            Console.WriteLine($"    City: {order.RecipientAddress.City}");
                            Console.WriteLine($"    Post/Zip/Area Code: {order.RecipientAddress.ZipOrPostalCode}");
                            Console.WriteLine($"    Country: {order.RecipientAddress.CountryName}");
                            Console.WriteLine($"Ordered By: {order.RecipientAddress.FullName}");
                            Console.WriteLine($"Status: {order.OrderStatus.ToString()}");
                        }

                        break;
                    case "3":
                        var productsRequest = client.GetProducts(new GetProductsRequest());
                        productsRequest.Wait();

                        var productResult = productsRequest.Result;

                        Console.WriteLine($"Page {productResult.Paging.Page} of {productResult.Paging.TotalPages}");
                        foreach (var product in productResult.Result)
                        {
                            Console.WriteLine($"ID: {product.Id}");
                            Console.WriteLine($"ExternalID: {product.ExternalId}");
                            Console.WriteLine($"Product Name: {product.Name}");
                            Console.WriteLine($"Variants (sizes and colours): {product.Variants}");
                            Console.WriteLine($"Synced: {product.Synced}");
                            Console.WriteLine($"Thumbnail: {product.ThumbnailUrl}");
                        }

                        break;
                    case "4":
                        var countryListRequest = client.GetCountryList();
                        countryListRequest.Wait();

                        var countryListResult = countryListRequest.Result;

                        foreach (var country in countryListResult.Countries)
                        {
                            Console.WriteLine($"Country Code: {country.Code}");
                            Console.WriteLine($"Country Name: {country.Name}");
                            Console.WriteLine($"Country State Count: {country.States?.Length ?? 0}");
                        }

                        break;
                    case "5":
                        var warehouseProductsRequest = client.GetWarehouseProducts(new GetWarehouseProductsRequest());
                        warehouseProductsRequest.Wait();

                        var warehouseProductsResult = warehouseProductsRequest.Result;

                        Console.WriteLine(
                            $"Page {warehouseProductsResult.Paging?.Page} of {warehouseProductsResult.Paging?.TotalPages}");

                        foreach (var warehouseProduct in warehouseProductsResult.WarehouseProducts)
                        {
                            Console.WriteLine($"Product ID: {warehouseProduct.ProductId}");
                        }

                        break;
                    case "6":
                        var getFilesRequest = client.GetFiles(new GetFilesRequest());
                        getFilesRequest.Wait();

                        var getFilesResponse = getFilesRequest.Result;

                        Console.WriteLine(
                            $"Page {getFilesResponse.ApiPaging.Page} of {getFilesResponse.ApiPaging.TotalPages}");

                        foreach (var file in getFilesResponse.Files)
                        {
                            Console.WriteLine($"FileId: {file.FileId}");
                            Console.WriteLine($"FileName: {file.FileName}");
                            Console.WriteLine($"Preview Url: {file.PreviewUrl}");
                        }

                        break;
                    case "7":
                        var fileId = Console.ReadLine();
                        var fileInformationRequest = client.GetFileInformation(new GetFileInformationRequest
                        {
                            FileId = int.Parse(fileId)
                        });
                        fileInformationRequest.Wait();

                        var fileInformationResponse = fileInformationRequest.Result;

                        Console.WriteLine($"FileId: {fileInformationResponse.File.FileId}");
                        Console.WriteLine($"FileName: {fileInformationResponse.File.FileName}");
                        Console.WriteLine($"PreviewUrl: {fileInformationResponse.File.PreviewUrl}");

                        break;
                    case "8":
                        var taxStatesRequest = client.GetRequiredTaxStates();
                        taxStatesRequest.Wait();

                        var taxStatesResponse = taxStatesRequest.Result;

                        foreach (var country in taxStatesResponse.Result)
                        {
                            Console.WriteLine($"Country Code: {country.Code}");
                            Console.WriteLine($"Country Name: {country.Name}");
                            Console.WriteLine($"States: ({country.States.Length})");
                            foreach (var state in country.States)
                            {
                                Console.WriteLine($"    State Code: {state.Code}");
                                Console.WriteLine($"    State Name: {state.Name}");
                            }
                        }

                        break;
                    case "9":
                        var checkTaxRequest = client.CalculateTaxRate(new TaxRequest
                        {
                            Recipient = new TaxAddressInfo
                            {
                                CountryCode = "",
                                StateCode = "",
                                City = "",
                                ZipOrPostCode = ""
                            }
                        });
                        checkTaxRequest.Wait();

                        var checkTaxResponse = checkTaxRequest.Result;
                        var isShippingTaxableString =
                            checkTaxResponse.Result.IsShippingTaxable ? " shipping is also taxable" : string.Empty;

                        Console.WriteLine(checkTaxResponse.Result.Required
                            ? $"Should Charge Tax at {checkTaxResponse.Result.Rate}{isShippingTaxableString}"
                            : "Should not charge tax");

                        break;
                    case "10":
                        var calculateShippingRequest = client.CalculateShippingRates(new ShippingRequest
                        {
                            RecipientAddressInfo = new AddressInfo
                            {
                                AddressLine1 = "",
                                City = "",
                                CountryCode = "",
                                ZipOrPostalCode = ""
                            },
                            Items = new ItemInfo[]
                            {
                                new ItemInfo
                                {
                                    ExternalVariantId = "",
                                    Quantity = 2
                                },
                                new ItemInfo
                                {
                                    ExternalVariantId = "",
                                    Quantity = 1
                                }
                            },
                            Currency = ""
                        });
                        calculateShippingRequest.Wait();

                        var calculateShippingResult = calculateShippingRequest.Result;

                        foreach (var shippingOption in calculateShippingResult.ShippingOptions)
                        {
                            Console.WriteLine($"Shipping Option Id: {shippingOption.Id}");
                            Console.WriteLine($"Shipping Option Name: {shippingOption.Name}");
                            Console.WriteLine(
                                $"Delivered within {shippingOption.MinimumDeliveryDays} - {shippingOption.MaximumDeliveryDays} days");
                            Console.WriteLine($"{shippingOption.CurrencyCode} {shippingOption.Rate}");
                        }

                        break;
                    case "11":
                        var getProductAndVariantsRequest = client.GetProductAndVariants(new GetProductAndVariantsRequest
                        {
                            ExternalId = ""
                        });
                        getProductAndVariantsRequest.Wait();

                        var getProductAndVariantsResponse = getProductAndVariantsRequest.Result;

                        Console.WriteLine($"Product Name: {getProductAndVariantsResponse.Result.SyncProduct.Name}");
                        Console.WriteLine($"Variants ({getProductAndVariantsResponse.Result.SyncProduct.Variants}");
                        foreach (var variant in getProductAndVariantsResponse.Result.SyncVariants)
                        {
                            Console.WriteLine($"ID: {variant.Id}");
                            Console.WriteLine($"Variant ID: {variant.VariantId}");
                            Console.WriteLine($"External ID: {variant.ExternalId}");
                            Console.WriteLine($"Name: {variant.Name}");
                            Console.WriteLine($"File Information:");

                            var nonPreviewFiles = variant.Files.Where(f => f.Type != "preview");
                            foreach (var file in nonPreviewFiles)
                            {
                                Console.WriteLine($"File Id: {file.FileId}");
                                Console.WriteLine($"File Name: {file.FileName}");
                                Console.WriteLine($"File Url: {file.Url}");
                            }
                        }

                        break;
                    case "12":

                        var createDraftOrderRequest = client.CreateOrder(new CreateNewOrderRequest
                        {
                            AutoSubmitForFulfillment = false,
                            UpdateExisting = false,
                            OrderData = new OrderInput
                            {
                                ExternalId = "",
                                GiftData = null,
                                ShippingMethod = "",
                                RecipientAddress = new Address
                                {
                                    AddressLine1 = "",
                                    City = "",
                                    FullName = "",
                                    CountryCode = "",
                                    CountryName = "",
                                    ZipOrPostalCode = "",
                                    Email = "",
                                    PhoneNumber = ""
                                },
                                OrderPackingSlip = null,
                                Items = new Item[]
                                {
                                    new Item
                                    {
                                        ExternalVariantId = "",
                                        Quantity = 1
                                    }
                                }
                            }
                        });

                        createDraftOrderRequest.Wait();

                        var createDraftOrderResponse = createDraftOrderRequest.Result;

                        Console.WriteLine($"OrderId: {createDraftOrderResponse.Order.OrderId}");
                        Console.WriteLine($"Order Status: {createDraftOrderResponse.Order.OrderStatus}");
                        Console.WriteLine($"Order Shipping Cost: {createDraftOrderResponse.Order.Costs.Shipping}");
                        Console.WriteLine($"Order VAT Cost: {createDraftOrderResponse.Order.Costs.VAT}");
                        Console.WriteLine($"Order Total Cost: {createDraftOrderResponse.Order.Costs.Total}");

                        Console.WriteLine($"Retail Cost: {createDraftOrderResponse.Order.RetailCosts.Shipping}");
                        Console.WriteLine($"Retail VAT Cost: {createDraftOrderResponse.Order.RetailCosts.VAT}");
                        Console.WriteLine($"Retail Total Cost: {createDraftOrderResponse.Order.RetailCosts.Total}");

                        break;

                    case "13":
                        var cancelOrderRequest = client.CancelOrder(new CancelOrderRequest
                        {
                            ExternalId = ""
                        });
                        cancelOrderRequest.Wait();

                        var cancelOrderResponse = cancelOrderRequest.Result;

                        Console.WriteLine($"OrderId: {cancelOrderResponse.CancelledOrder.OrderId}");
                        Console.WriteLine($"Order Status: {cancelOrderResponse.CancelledOrder.OrderStatus}");
                        break;
                    case "14":
                        var categories = client.GetCategories();

                        var getCategoriesResponse = categories.Result;

                        Console.WriteLine($"Status Code: {getCategoriesResponse.StatusCode}");
                        foreach (var category in getCategoriesResponse.CategoriesContainer.Categories)
                        {
                            Console.WriteLine($"ID: {category.Id}");
                            Console.WriteLine($"ParentId: {category.ParentId}");
                            Console.WriteLine($"ImageUrl: {category.ImageUrl}");
                            Console.WriteLine($"Size: {category.Size}");
                            Console.WriteLine($"Title: {category.Title}");
                        }

                        break;
                    case "15":
                        var categoryResponse = client.GetCategory(new GetCategoryRequest
                        {
                            CategoryId = 116
                        });

                        var categoryResult = categoryResponse.Result.Category;

                        Console.WriteLine($"ID: {categoryResult.Id}");
                        Console.WriteLine($"ParentId: {categoryResult.ParentId}");
                        Console.WriteLine($"ImageUrl: {categoryResult.ImageUrl}");
                        Console.WriteLine($"Size: {categoryResult.Size}");
                        Console.WriteLine($"Title: {categoryResult.Title}");
                        break;
                    case "16":
                        var searchProductsWithCategoryRequest = client.GetProducts(new GetProductsRequest
                        {
                            CategoryId = 5,
                            SearchTerms = "Mug"
                        });
                        searchProductsWithCategoryRequest.Wait();

                        var searchProductsWithCategoryResult = searchProductsWithCategoryRequest.Result;

                        Console.WriteLine($"Page {searchProductsWithCategoryResult.Paging.Page} of {searchProductsWithCategoryResult.Paging.TotalPages}");
                        foreach (var product in searchProductsWithCategoryResult.Result)
                        {
                            Console.WriteLine($"ID: {product.Id}");
                            Console.WriteLine($"ExternalID: {product.ExternalId}");
                            Console.WriteLine($"Product Name: {product.Name}");
                            Console.WriteLine($"Variants (sizes and colours): {product.Variants}");
                            Console.WriteLine($"Synced: {product.Synced}");
                            Console.WriteLine($"Thumbnail: {product.ThumbnailUrl}");
                        }

                        break;
                    case "17":
                        var searchProductsRequest = client.GetProducts(new GetProductsRequest
                        {
                            SearchTerms = "Mug"
                        });
                        searchProductsRequest.Wait();

                        var searchProductResult = searchProductsRequest.Result;

                        Console.WriteLine($"Page {searchProductResult.Paging.Page} of {searchProductResult.Paging.TotalPages}");
                        foreach (var product in searchProductResult.Result)
                        {
                            Console.WriteLine($"ID: {product.Id}");
                            Console.WriteLine($"ExternalID: {product.ExternalId}");
                            Console.WriteLine($"Product Name: {product.Name}");
                            Console.WriteLine($"Variants (sizes and colours): {product.Variants}");
                            Console.WriteLine($"Synced: {product.Synced}");
                            Console.WriteLine($"Thumbnail: {product.ThumbnailUrl}");
                        }

                        break;
                    case "20":
                        keepRunning = false;
                        break;
                }
            }
        }
    }
}
