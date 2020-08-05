using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Interfaces;

namespace PrintfulLib
{
    public class PrintfulHttpClient : HttpClient, IPrintfulHttpClient
    {
        public async Task<T> GetAsync<T>(string url)
        {
            var apiResponse = await this.GetAsync(url);

            return await ProcessResponse<T>(apiResponse);
        }

        public async Task<T1> PostAsync<T1, T2>(string url, T2 requestObject)
        {
            var apiResponse = await this.PostAsync(url, HttpClientHelper.GetJsonData(requestObject));

            return await ProcessResponse<T1>(apiResponse);
        }

        public async Task<T> DeleteAsync<T>(string url)
        {
            var apiResponse = await this.DeleteAsync(url);

            return await ProcessResponse<T>(apiResponse);
        }

        public async Task<T1> PutAsync<T1, T2>(string url, T2 requestObject)
        {
            var apiResponse = await this.PutAsync(url, HttpClientHelper.GetJsonData(requestObject));

            return await ProcessResponse<T1>(apiResponse);
        }

        private async Task<T> ProcessResponse<T>(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
                throw new Exception(
                    $"Api responded with status code: {response.StatusCode}. Reason: {response.ReasonPhrase}");

            var jsonString = await response.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<T>(jsonString);

            return data;
        }
    }
}