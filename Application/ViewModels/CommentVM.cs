﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels
{
    public class CommentVM
    {
        public int id { get; set; }
        public int postId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }
}
