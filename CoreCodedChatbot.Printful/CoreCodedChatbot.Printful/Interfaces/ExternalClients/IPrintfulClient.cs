using System.Collections.Generic;
using System.Threading.Tasks;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Interfaces.ExternalClients
{
    public interface IPrintfulClient
    {
        Task<List<GetSyncVariantsResult>> GetAllProducts();
        Task<List<GetSyncVariantsResult>> GetRelevantProducts(string searchTerm);
        Task<GetSyncVariantsResult> GetVariantsById(int id);
    }
}