using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Models
{
    public class TagVM
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string UrlSlug { get; set; }

        public string Description { get; set; }
        public int Count { get; set; }
        public bool IsEnable { get; set; }
    }
    public class PopularTagVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string UrlSlug { get; set; }
        public bool IsEnable { get; set; }
    }
    public class GetTagsByPostVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }

    }
}
