using Newtonsoft.Json;

namespace PrintfulLib.Models.ChildObjects
{
    public class PrintfulProductFile
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Type { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("size")]
        public double Size { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("dpi")]
        public int Dpi { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }
}