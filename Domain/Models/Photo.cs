using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class Photo
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("title")] public string Title { get; set; }
        [JsonPropertyName("url")] public string Url { get; set; }
        [JsonPropertyName("thumbnailUrl")] public string ThumbnailUrl { get; set; }
        [JsonPropertyName("albumID")] public int AlbumID { get; set; }
        public virtual Album Album { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
