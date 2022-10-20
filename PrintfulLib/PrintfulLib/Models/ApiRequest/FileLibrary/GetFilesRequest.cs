namespace PrintfulLib.Models.ApiRequest.FileLibrary
{
    public class GetFilesRequest
    {
        public string FilterStatus { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
    }
}