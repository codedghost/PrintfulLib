using PrintfulLib.Helpers;
using PrintfulLib.Interfaces;

namespace PrintfulLib.Services
{
    internal abstract class PrintfulServiceBase : IPrintfulServiceBase
    {
        protected readonly PrintfulHttpClient _client;

        internal PrintfulServiceBase(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }
    }
}