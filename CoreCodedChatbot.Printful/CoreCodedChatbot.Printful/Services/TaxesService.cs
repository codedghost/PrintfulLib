using System.Net.Http;
using PrintfulLib.Helpers;

namespace PrintfulLib.Services
{
    internal class TaxesService
    {
        private readonly HttpClient _client;

        internal TaxesService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }
    }
}