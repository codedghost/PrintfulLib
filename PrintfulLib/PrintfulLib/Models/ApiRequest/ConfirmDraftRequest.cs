namespace PrintfulLib.Models.ApiRequest
{
    public class ConfirmDraftRequest
    {
        public int OrderId { get; set; }
        public string ExternalId { get; set; }
    }
}