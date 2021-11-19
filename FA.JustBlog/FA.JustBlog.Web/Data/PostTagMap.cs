using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Data
{
    public class PostTagMap
    {
        public Posts Post { get; set; }
        public Tags Tags { get; set; }
        
        
        public int PostId { get; set; }
        
       
        public int TagId { get; set; }
    }
}
