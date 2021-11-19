using FA.JustBlog.Web.Contract;
using FA.JustBlog.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Categories entity)
        {
            _db.Categories.Add(entity);
            return Save();
        }

        public bool Delete(Categories entity)
        {
            _db.Categories.Remove(entity);
            return Save();
        }

        public ICollection<Categories> FindAll()
        {
            return _db.Categories.ToList();
        }

        public Categories FindById(int id)
        {
            return _db.Categories.Find(id);
        }

        public Categories FindByUrlSlug(string urlSlug)
        {
            var result = _db.Categories.FirstOrDefault(x => x.UrlSlug.Equals(urlSlug));
            return result;
        }

        public bool isExist(int id)
        {
            var exists = _db.Categories.Any(x => x.Id.Equals(id));
            return exists;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(Categories entity)
        {
            _db.Categories.Update(entity);
            return Save();
        }
    }
}
