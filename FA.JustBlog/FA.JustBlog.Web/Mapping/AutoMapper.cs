using AutoMapper;
using FA.JustBlog.Web.Data;
using FA.JustBlog.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Mappings
{
    public class Mapper : Profile
    {
       public Mapper()
        {
            CreateMap<Categories, CategoryVM>().ReverseMap();
            CreateMap<Categories, ListCategory>().ReverseMap();
            CreateMap<Posts, PostVM>().ReverseMap();
            CreateMap<Tags, PopularTagVM>().ReverseMap();
            CreateMap<Tags, GetTagsByPostVM>().ReverseMap();
            CreateMap<Posts, GetPostDetailVM>().ReverseMap();
            CreateMap<Posts, PostTagMapAndPost>().ReverseMap();
            CreateMap<Categories, CategoryByPost>().ReverseMap();
            CreateMap<Posts, CardForPostVM>().ReverseMap();
            CreateMap<Posts, CreatePostVM>().ReverseMap();
           
            
            CreateMap<Tags, TagVM>().ReverseMap();
        }
    }
}
