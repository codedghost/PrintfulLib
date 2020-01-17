using System.Net.Http;
using PrintfulLib.Helpers;

namespace PrintfulLib.Services
{
    internal class ShippingService
    {
        private HttpClient _client;

        internal ShippingService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }
    }
}