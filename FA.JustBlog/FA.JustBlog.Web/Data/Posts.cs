using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Data
{
    public class Posts
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }
        public bool? Published { get; set; }
        public DateTime PostOn { get; set; }
        public bool IsEnable { get; set; }
        public bool? Modified { get; set; }

        public Categories Category { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public Users User { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get; set; }

        public int ViewCount { get; set; }
        public int RateCount { get; set; }

        public int TotalRate { get; set; }
        public string PostContent { get; set; }
        public virtual ICollection<PostTagMap> PostTagMap { get; set; }
    }
}
