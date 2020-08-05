namespace PrintfulLib.Models.ChildObjects
{
    public class PutRequestProductBody
    {
        public RequestProduct Product { get; set; }
        public PutRequestVariant[] Variants { get; set; }
    }
}