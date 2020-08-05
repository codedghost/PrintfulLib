using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace PrintfulLib.Interfaces
{
    public interface IPrintfulHttpClient
    {
        Task<T> GetAsync<T>(string url);
        Task<T1> PostAsync<T1, T2>(string url, T2 requestObject);
    }
}