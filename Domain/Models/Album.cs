using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class Album
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("title")] public string Title { get; set; }
        [JsonPropertyName("photos")] public virtual ICollection<Photo> Photos { get; set; } 
    }
}
