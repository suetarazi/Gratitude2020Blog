﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }

    }
}
