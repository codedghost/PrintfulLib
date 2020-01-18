using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

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

        internal static ByteArrayContent GetJsonData(object data)
        {
            var jsonData = JsonConvert.SerializeObject(data);
            var byteContent = new ByteArrayContent(Encoding.UTF8.GetBytes(jsonData));
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return byteContent;
        }
    }
}