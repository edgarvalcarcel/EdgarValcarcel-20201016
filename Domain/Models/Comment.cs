using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class Comment
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("email")] public string Email { get; set; }
        [JsonPropertyName("body")] public string Body { get; set; }
        [JsonPropertyName("postId")] public int PostId { get; set; } 
        public virtual Photo Photo { get; set; }
    }
}
