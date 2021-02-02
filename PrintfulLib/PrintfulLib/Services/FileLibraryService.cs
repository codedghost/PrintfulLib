using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Services
{
    public class FileLibraryService
    {
        private PrintfulHttpClient _client;

        public FileLibraryService(string apiKey)
        {
            _client = HttpClientHelper.GetPrintfulClient(apiKey);
        }

        public async Task<GetFilesResponse> GetFiles(GetFilesRequest request)
        {
            if (request == null)
                throw new Exception("No data provided to request");
            if (request.Limit > 100)
                throw new Exception($"Maximum number of items per page is 100");

            if (request.Limit == 0) request.Limit = 100;

            var filterQueryString = string.IsNullOrWhiteSpace(request.FilterStatus)
                ? string.Empty
                : $"&status={request.FilterStatus}";

            var apiResponse =
                await _client.GetAsync<GetFilesResponse>($"files?offset={request.Offset}&limit={request.Limit}{filterQueryString}");

            return apiResponse;
        }

        public async Task<GetFileInformationResponse> GetFileInformation(GetFileInformationRequest request)
        {
            if (request == null || request.FileId == 0)
                throw new Exception("No data provided to request");

            var apiResponse = await _client.GetAsync<GetFileInformationResponse>($"files/{request.FileId}");

            return apiResponse;
        }

        public async Task<AddFileResponse> AddFile(AddFileRequest request)
        {
            if (string.IsNullOrWhiteSpace(request?.File?.Url))
                throw new Exception("No data provided to request");

            var apiResponse = await _client.PostAsync<AddFileResponse, File>("files", request.File);

            return apiResponse;
        }
    }
}