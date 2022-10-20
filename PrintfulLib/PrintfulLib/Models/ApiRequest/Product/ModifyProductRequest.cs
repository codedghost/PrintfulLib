using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Models.ApiRequest.Product
{
    public class ModifyProductRequest
    {
        public int ProductId { get; set; }
        public string ExternalId { get; set; }
        public PutRequestProductBody PutRequestProductBody { get; set; }
    }
}