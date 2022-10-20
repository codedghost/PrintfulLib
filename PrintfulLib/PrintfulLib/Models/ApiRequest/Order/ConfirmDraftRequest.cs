namespace PrintfulLib.Models.ApiRequest.Order
{
    public class ConfirmDraftRequest
    {
        public int OrderId { get; set; }
        public string ExternalId { get; set; }
    }
}