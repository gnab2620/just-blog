using AutoMapper;
using FA.JustBlog.Web.Contract;
using FA.JustBlog.Web.Data;
using FA.JustBlog.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using FA.JustBlog.Web.SeoURL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FA.JustBlog.Web.Controllers
{
    
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepo;
        private readonly IPostTagMapRepository _postTagMapRepository;
        private readonly ICategoryRepository _categoryRepo;
        private readonly ITagRepository _tagRepo;
        private readonly IMapper _mapper;
        private readonly UserManager<Users> _userManager;

        public PostController(IPostRepository postRepo, IPostTagMapRepository postTagMapRepository, ICategoryRepository categoryRepo, ITagRepository tagRepo, IMapper mapper, UserManager<Users> userManager)
        {
            _postRepo = postRepo;
            _postTagMapRepository = postTagMapRepository;
            _categoryRepo = categoryRepo;
            _tagRepo = tagRepo;
            _mapper = mapper;
            _userManager = userManager;
        }








        // GET: PostController
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: PostController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult GetPostDetails(string year, string month, string seoUrl)
        
        {
            var detail = _postRepo.GetPostDetail(year, month, seoUrl);
            if (detail==null || detail.Published == false)
            {
                return NotFound();
            }
            var model = _mapper.Map<Posts, GetPostDetailVM>(detail);

            model.ListTag = new List<Tags>(_postTagMapRepository.GetTagsByPost(model.Id).ToList());
            
            return View("GetPostDetails",model);
        }
        public ActionResult _GetTagsByPost(int id)
        {
            var collection = _postTagMapRepository.GetTagsByPost(id).ToList();
            var model = _mapper.Map<List<Tags>, List<GetTagsByPostVM>>(collection);

            return PartialView("_GetTagsByPost", model);
        }

        public ActionResult MyPost()
        {
            var user = _userManager.GetUserAsync(User).Result;
            var postbyuser = _postRepo.GetPostsByUser(user.Id);

            var collection = _mapper.Map<List<PostVM>>(postbyuser);
            foreach (var item in collection)
            {
                item.ListTag = _postTagMapRepository.GetTagsByPost(item.Id).ToList();
            }
            var model = new PostsByUser
            {
                Posts = collection
            };
            return View(model);
        }
        [Authorize]
        // GET: PostController/Create
        public ActionResult Create()
        {
            CreatePostVM createPostVM = new CreatePostVM()
            {
                Categories = _categoryRepo.FindAll().ToList(),
                Tags =_tagRepo.FindAll().ToList()
            };

            return View(createPostVM);
        }

        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreatePostVM collection)
        {
            try
            {
                var user = _userManager.GetUserAsync(User).Result;
                var model = _mapper.Map<Posts>(collection);
                model.UserId = user.Id;
                model.ViewCount = 0;
                model.RateCount = 0;
                model.TotalRate = 0;
                model.PostOn = DateTime.Now;
                model.UrlSlug = UrlHepler.FrientlyUrl(model.Title);

                if (_postRepo.Create(model))
                {
                    int id = model.Id;
                    foreach (var item in collection.MultipleTagId)
                    {
                        PostTagMap postTagMaps = new PostTagMap()
                        {
                            PostId = id,
                            TagId = item
                        };
                        _postTagMapRepository.Create(postTagMaps);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Something went wrong");
                    return View(collection);
                }

                return RedirectToAction(nameof(MyPost));
            }
            catch
            {
                return View(collection);
            }
        }
        [Authorize]
        // GET: PostController/Edit/5
        public ActionResult Edit(int id)
        {
            var post = _postRepo.FindById(id);
            var user = _userManager.GetUserAsync(User).Result;

            if (post.UserId==user.Id)
            {
                var categories = _categoryRepo.FindAll().ToList();
                var tag = _tagRepo.FindAll().ToList();
                int[] posttag = _postTagMapRepository.GetTagsByPost(id).Select(x => x.Id).ToArray();
                EditPostVM editPostVM = new EditPostVM()
                {
                    MultipleTagId = posttag,
                    Categories = categories,
                    Tags = tag,
                    ShortDescription = post.ShortDescription,
                    Title = post.Title,
                    PostContent = post.PostContent,
                    CategoryId = post.CategoryId
                };


                return View(editPostVM);
            }
            return View("AccessDenied");
        }

        // POST: PostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditPostVM collection)
        {
            try
            {
                var post = _postRepo.FindById(collection.Id);
                post.Title = collection.Title;
                post.UrlSlug = UrlHepler.FrientlyUrl(collection.Title);
                post.ShortDescription = collection.ShortDescription;
                post.PostContent = collection.PostContent;
                post.CategoryId = collection.CategoryId;

                if (_postRepo.Update(post))
                {
                    int id = post.Id;
                    int[] currentTag = _postTagMapRepository.GetTagsByPost(id).Select(x => x.Id).ToArray();

                    var createTags = collection.MultipleTagId.Except(currentTag).ToArray();
                    var deleteTags = currentTag.Except(collection.MultipleTagId).ToArray();
                    if (deleteTags.Length>0)
                    {
                        foreach (var item in deleteTags)
                        {
                            PostTagMap postTagMaps = new PostTagMap()
                            {
                                PostId = id,
                                TagId = item
                            };
                            _postTagMapRepository.Delete(postTagMaps);
                        }
                    }
                    else
                    {
                        if (createTags.Length>0)
                        {
                            foreach (var item in createTags)
                            {
                                PostTagMap postTagMaps = new PostTagMap()
                                {
                                    PostId = id,
                                    TagId = item
                                };
                                _postTagMapRepository.Create(postTagMaps);
                            }
                        }
                    }
                    
                       
                      
                    
                }
                else
                {
                    ModelState.AddModelError("", "Something went wrong");
                    return View(collection);
                }

                return RedirectToAction(nameof(MyPost));
            }
            catch
            {
                return View(collection);
            }
        }
    
        public ActionResult _GetCategoryByPost(int id)
        {
            var cate =  _postRepo.GetCategoryForPost(id).ToList();
            var model = _mapper.Map<List<Categories>, List<CategoryByPost>>(cate);
            return  PartialView("_GetCategoryByPost", model);
        }
        public ActionResult _GetLastedPost()
        {
            var mostviewpost = _postRepo.GetLastestPost(5).ToList();
            var model1 = _mapper.Map<List<Posts>, List<CardForPostVM>>(mostviewpost);
            foreach (var item in model1)
            {
                item.ListTag = _postTagMapRepository.GetTagsByPost(item.Id).ToList();
            }

            PostTagMapAndPost postTagMapAndPost = new PostTagMapAndPost
            {
                CardForPostVM = model1,
            };




            return PartialView("_GetLastedPost", postTagMapAndPost);
        }
        public ActionResult MostViewedPosts()
        {
           

            var mostviewpost = _postRepo.GetPostHighestViewCount(5).ToList();
            var model1 = _mapper.Map<List<Posts>, List<CardForPostVM>>(mostviewpost);
            foreach (var item in model1)
            {
                item.ListTag = new List<Tags>(_postTagMapRepository.GetTagsByPost(item.Id).ToList());
            }

            PostTagMapAndPost postTagMapAndPost = new PostTagMapAndPost
            {
                CardForPostVM = model1,
            };

            


            return PartialView("MostViewedPosts", postTagMapAndPost);
        }
       
        public ActionResult PostsByCategoryUrlSlug(string UrlSlug)
        {
            var posts = _postRepo.GetPostsByCategoryUrlSlug(UrlSlug).ToList();
            var category = _categoryRepo.FindByUrlSlug(UrlSlug);
            var model1 = _mapper.Map<List<Posts>, List<CardForPostVM>>(posts);
           foreach (var item in model1)
            { 
                item.ListTag = new List<Tags>(_postTagMapRepository.GetTagsByPost(item.Id).ToList());
            }

            PostTagMapAndPost postTagMapAndPost = new PostTagMapAndPost
            {
                CardForPostVM = model1,
                CategoriesUrlSlug = UrlSlug,
                CategoriesName = category.Name
            };




            return View("PostsByCategoryUrlSlug", postTagMapAndPost);
        }
        public ActionResult CancelRequest(int id)
        {
            try
            {
                var leaverequest = _postRepo.FindById(id);


                _postRepo.Delete(leaverequest);
                return RedirectToAction("MyPost");

            }
            catch (Exception)
            {
                return RedirectToAction("MyPost");
            }

        }
        public ActionResult PostsByTagUrlSlug(string UrlSlug)
        {
              var posts = _postTagMapRepository.GetPostsByTagUrlSlug(UrlSlug).ToList();
           
                var tags = _tagRepo.FindByUrlSlug(UrlSlug);

                var model1 = _mapper.Map<List<Posts>, List<CardForPostVM>>(posts);
                foreach (var item in model1)
                {
                    item.Category = _categoryRepo.FindById(item.CategoryId);
                    item.ListTag = new List<Tags>(_postTagMapRepository.GetTagsByPost(item.Id).ToList());
                }

                PostTagMapAndPost postTagMapAndPost = new PostTagMapAndPost
                {
                    CardForPostVM = model1,
                    TagUrlSlug = UrlSlug,
                    TagName = tags.Name
                };




                return View("PostsByTagUrlSlug", postTagMapAndPost);
           
        }

        // GET: PostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
