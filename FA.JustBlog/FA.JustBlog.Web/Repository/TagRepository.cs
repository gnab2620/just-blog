using FA.JustBlog.Web.Contract;
using FA.JustBlog.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Repository
{
    public class TagRepository : ITagRepository
    {
        public readonly ApplicationDbContext _db;

        public TagRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Tags entity)
        {
            _db.Tags.Add(entity);
            return Save();
        }

        public bool Delete(Tags entity)
        {
            _db.Tags.Remove(entity);
            return Save();
        }

        public ICollection<Tags> FindAll()
        {
            return _db.Tags.ToList();
        }

        public Tags FindById(int id)
        {
            return _db.Tags.Find(id);
        }

        public Tags FindByUrlSlug(string urlSlug)
        {
            var result = FindAll().FirstOrDefault(x => x.UrlSlug.Equals(urlSlug));
            return result;
        }

        public ICollection<Tags> GetPopularTag(int take)
        {
            var result = FindAll().OrderByDescending(x => x.Count).Take(take).ToList();
            return result;
        }

        public bool isExist(int id)
        {
            var exists = _db.Tags.Any(x => x.Id.Equals(id));
            return exists;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(Tags entity)
        {
            _db.Tags.Update(entity);
            return Save();
        }
    }
}
