using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels
{
    public class PhotoVM
    {
        public int id { get; set; }
        public int albumId { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }        
    }
}
