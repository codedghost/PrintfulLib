using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class Category
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}