using System.Net.Http;
using PrintfulLib.Helpers;

namespace PrintfulLib.Services
{
    internal class CountryService
    {
        private readonly HttpClient _client;

        internal CountryService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }
    }
}