using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Services
{
    public class FileLibraryService
    {
        private HttpClient _client;

        public FileLibraryService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }

        public async Task<GetFilesResponse> GetFiles(GetFilesRequest request)
        {
            if (request == null || request.Limit == 0)
                throw new Exception("No data provided to request");
            if (request.Limit > 100)
                throw new Exception($"Maximum number of items per page is 100");

            var filterQueryString = string.IsNullOrWhiteSpace(request.FilterStatus)
                ? string.Empty
                : $"&status={request.FilterStatus}";
            var apiResponse =
                await _client.GetAsync($"files?offset={request.Offset}&limit={request.Limit}{filterQueryString}");

            if (!apiResponse.IsSuccessStatusCode)
                throw new Exception(
                    $"Api responded with status code: {apiResponse.StatusCode}. Reason: {apiResponse.ReasonPhrase}");

            var jsonString = await apiResponse.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<GetFilesResponse>(jsonString);

            return data;
        }

        public async Task<GetFileInformationResponse> GetFileInformation(GetFileInformationRequest request)
        {
            if (request == null || request.FileId == 0)
                throw new Exception("No data provided to request");

            var apiResponse = await _client.GetAsync($"files/{request.FileId}");

            if (!apiResponse.IsSuccessStatusCode)
                throw new Exception($"Api responded with status code: {apiResponse.StatusCode}. Reason: {apiResponse.ReasonPhrase}");

            var jsonString = await apiResponse.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<GetFileInformationResponse>(jsonString);

            return data;
        }

        public async Task<AddFileResponse> AddFile(AddFileRequest request)
        {
            if (string.IsNullOrWhiteSpace(request?.File?.Url))
                throw new Exception("No data provided to request");

            var apiResponse = await _client.PostAsync("files", HttpClientHelper.GetJsonData(request.File));

            if (!apiResponse.IsSuccessStatusCode)
                throw new Exception($"Api responded with status code: {apiResponse.StatusCode}. Reason: {apiResponse.ReasonPhrase}");

            var jsonString = await apiResponse.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<AddFileResponse>(jsonString);

            return data;
        }
    }
}