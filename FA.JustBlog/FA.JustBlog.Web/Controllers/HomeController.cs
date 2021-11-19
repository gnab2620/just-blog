using AutoMapper;
using FA.JustBlog.Web.Contract;
using FA.JustBlog.Web.Data;
using FA.JustBlog.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository _postRepo;
        private readonly IPostTagMapRepository _postTagMapRepository;
        private readonly ICategoryRepository _categoryRepo;
        private readonly ITagRepository _tagRepo;
        private readonly IMapper _mapper;

        public HomeController(IPostRepository postRepo, IPostTagMapRepository postTagMapRepository, ICategoryRepository categoryRepo, ITagRepository tagRepo, IMapper mapper)
        {
            _postRepo = postRepo;
            _postTagMapRepository = postTagMapRepository;
            _categoryRepo = categoryRepo;
            _tagRepo = tagRepo;
            _mapper = mapper;
        }
        

        
        
        

        public ActionResult Index()
        {
            var lastedpost = _postRepo.GetLastestPost(5).ToList();
            var model1 = _mapper.Map<List<Posts>, List<CardForPostVM>>(lastedpost);
            var mostviewpost = _postRepo.GetPostHighestViewCount(5).ToList();
            var model2 = _mapper.Map<List<Posts>, List<CardForPostVM>>(mostviewpost);
            foreach (var item in model1)
            {
                item.ListTag = _postTagMapRepository.GetTagsByPost(item.Id).ToList();
            }
            foreach (var item in model2)
            {
                item.ListTag = _postTagMapRepository.GetTagsByPost(item.Id).ToList();
            }

            MostViewPostAndLastedPost postTagMapAndPost = new MostViewPostAndLastedPost
            {
                LastedPosts = model2,
                MostViewPosts = model1
            };
            return View(postTagMapAndPost);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
