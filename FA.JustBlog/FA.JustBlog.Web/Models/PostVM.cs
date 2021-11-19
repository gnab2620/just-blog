using FA.JustBlog.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Models
{
    public class PostVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }
        public bool? Published { get; set; }
        public string PostOn { get; set; }

        public bool? Modified { get; set; }

        public Categories Category { get; set; }
       
        public int CategoryId { get; set; }

        public Users User { get; set; }
        
        public string UserId { get; set; }

        public int ViewCount { get; set; }
        public int RateCount { get; set; }

        public int TotalRate { get; set; }
        public string PostContent { get; set; }
        public bool IsEnable { get; set; }
        public List<Tags> ListTag { get; set; }
    }
    public class CardForPostVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public int ViewCount { get; set; }
        public int RateCount { get; set; }
        public DateTime PostOn { get; set; }
        public string UrlSlug { get; set; }
        public Categories Category { get; set; }

        public int CategoryId { get; set; }

        public Users User { get; set; }

        public string UserId { get; set; }
        public List<Tags> ListTag { get; set; }
    }
 
    public class GetPostDetailVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }
        public bool? Published { get; set; }
        public DateTime PostOn { get; set; }
        public string PostContent { get; set; }
        public Categories Category { get; set; }

        public int CategoryId { get; set; }

        public Users User { get; set; }

        public string UserId { get; set; }
        public List<Tags> ListTag { get; set; }
    }
    public class PostTagMapAndPost
    {
        public List<CardForPostVM> CardForPostVM { get; set; }

        public string CategoriesUrlSlug { get; set; }

        public string CategoriesName { get; set; }

        public string TagUrlSlug { get; set; }

        public string TagName { get; set; }
    }
    public class MostViewPostAndLastedPost
    {
        public List<CardForPostVM> MostViewPosts { get; set; }
        public List<CardForPostVM> LastedPosts { get; set; }
    }
    public class CreatePostVM
    {
        
        public IEnumerable<Categories> Categories { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<Tags> Tags { get; set; }
        public int[] MultipleTagId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }
        public DateTime PostOn { get; set; }
        public string PostContent { get; set; }

    }
    public class EditPostVM
    {
        public int Id { get; set; }
        public IEnumerable<Categories> Categories { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<Tags> Tags { get; set; }
        public int[] MultipleTagId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }
        public DateTime PostOn { get; set; }
        public string PostContent { get; set; }

    }
    public class PostsByUser
    {
        public List<PostVM> Posts { get; set; }
    }
}
