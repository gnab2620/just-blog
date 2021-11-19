using AutoMapper;
using FA.JustBlog.Web.Contract;
using FA.JustBlog.Web.Data;
using FA.JustBlog.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Controllers
{
    
    public class TagsController : Controller
    {
        private readonly ITagRepository _tagRepo;
        private readonly IMapper _mapper;

        public TagsController(ITagRepository tagRepo, IMapper mapper)
        {
            _tagRepo = tagRepo;
            _mapper = mapper;
        }

        // GET: TagsController
        public ActionResult Index()
        {
            var tag = _tagRepo.FindAll().ToList();
            var model = _mapper.Map<List<Tags>, List<TagVM>>(tag);

            return View(model);
            
        }

        // GET: TagsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult GetPopularTag()
        {
            var populartag = _tagRepo.GetPopularTag(10).ToList();
            var model = _mapper.Map<List<Tags>, List<PopularTagVM>>(populartag);

            return PartialView("GetPopularTag",model);
        }

        // GET: TagsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TagsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TagVM collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(collection);
                }
                var model = _mapper.Map<Tags>(collection);
                model.IsEnable = true;
                var isSuccess = _tagRepo.Create(model);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Somthing went wrong");
                    return View(collection);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TagsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TagsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: TagsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TagsController/Delete/5
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
