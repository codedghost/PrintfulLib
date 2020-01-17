using System.Collections.Generic;
using System.Threading.Tasks;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Interfaces.ExternalClients
{
    public interface IPrintfulClient
    {
        Task<GetSyncProductsResult> GetAllProducts();
        Task<GetSyncProductsResult> SearchAllProducts(string searchTerm);
        Task<List<GetSyncVariantsResult>> GetAllProductsWithVariants();
        Task<List<GetSyncVariantsResult>> SearchAllProductsWithVariants(string searchTerm);
        Task<GetSyncVariantsResult> GetVariantsById(int id);
    }
}