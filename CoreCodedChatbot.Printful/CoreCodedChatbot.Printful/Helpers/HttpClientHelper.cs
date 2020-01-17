using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace PrintfulLib.Helpers
{
    internal static class HttpClientHelper
    {
        internal static HttpClient GetPrintfulClient(string apiKey)
        {
            return new HttpClient
            {
                BaseAddress = new Uri("https://api.printful.com/"),
                DefaultRequestHeaders =
                {
                    Authorization = new AuthenticationHeaderValue("Basic",
                        Convert.ToBase64String(Encoding.UTF8.GetBytes(apiKey)))
                }
            };
        }
    }
}