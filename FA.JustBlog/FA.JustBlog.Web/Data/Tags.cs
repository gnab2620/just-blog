﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Data
{
    public class Tags
    {
       [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlSlug  { get; set; }
        public bool IsEnable { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public virtual ICollection<PostTagMap> PostTagMap { get; set; }
    }
}
