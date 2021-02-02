using System;
using Newtonsoft.Json;
using PrintfulLib.Converters;

namespace PrintfulLib.Models.ChildObjects
{
    public class File
    {
        [JsonProperty("id")]
        public int? FileId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("size")]
        public int? SizeBytes { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("dpi")]
        public int? Dpi { get; set; }

        [JsonProperty("status")]
        public string ProcessingStatus { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampDateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("options")]
        public FileOption[] FileOptions { get; set; }
    }
}