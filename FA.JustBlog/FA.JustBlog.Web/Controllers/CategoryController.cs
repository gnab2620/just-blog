using AutoMapper;
using FA.JustBlog.Web.Contract;
using FA.JustBlog.Web.Data;
using FA.JustBlog.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Controllers
{
    
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }
        [Authorize(Roles = "Administrator")]
        // GET: CategoryController
        public ActionResult Index()
        {
            var cate = _categoryRepo.FindAll().ToList();
            var model = _mapper.Map<List<Categories>, List<CategoryVM>>(cate);

            return View(model);
        }
        public ActionResult GetListCategory()
        {
            var cate = _categoryRepo.FindAll().ToList();
            var model = _mapper.Map<List<Categories>, List<ListCategory>>(cate);

            return PartialView("GetListCategory", model);
        }
        // GET: CategoryController/Details/5
        [Authorize(Roles = "Administrator")]
        public ActionResult Details(int id)
        {
            if (!_categoryRepo.isExist(id))
            {
                return NotFound();
            }
            var leaveType = _categoryRepo.FindById(id);
            var model = _mapper.Map<CategoryVM>(leaveType);

            return View(model);
        }

        // GET: CategoryController/Create
        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public ActionResult Create(CategoryVM collection)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(collection);
                }
                var model = _mapper.Map<Categories>(collection);
                model.IsEnable = true;
                var isSuccess = _categoryRepo.Create(model);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Somthing went wrong");
                    return View(collection);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message+"  Somthing went wrong");
                return View();
            }
        }
        [Authorize(Roles = "Administrator")]
        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_categoryRepo.isExist(id))
            {
                return NotFound();
            }
            var category = _categoryRepo.FindById(id);
            var model = _mapper.Map<CategoryVM>(category);
            return View(model);
        }
        [Authorize(Roles = "Administrator")]
        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( CategoryVM collection)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(collection);
                }
                var model = _mapper.Map<Categories>(collection);

                var isSuccess = _categoryRepo.Update(model);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Somthing went wrong");
                    return View(collection);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Somthing went wrong");
                return View();
            }
        }
        [Authorize(Roles = "Administrator")]
        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
           
            if (!_categoryRepo.isExist(id))
            {
                return NotFound();
            }
            var collection = _categoryRepo.FindById(id);

            var isSuccess = _categoryRepo.Delete(collection);
            if (!isSuccess)
            {
                ModelState.AddModelError("", "Somthing went wrong");
                return View(collection);
            }
            return RedirectToAction(nameof(Index));
            
        }
        [Authorize(Roles = "Administrator")]
        [Authorize(Roles = "Administrator")]
        [Authorize(Roles = "Administrator")]
        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CategoryVM collection)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(collection);
                }
                var model = _mapper.Map<Categories>(collection);

                var isSuccess = _categoryRepo.Delete(model);
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
    }
}
