using FA.JustBlog.Web.Contract;
using FA.JustBlog.Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Repository
{
    public class PostRepository : IPostRepository
    {
        public readonly ApplicationDbContext _db;

        public PostRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Posts entity)
        {
            _db.Posts.Add(entity);
            return Save();
        }

        public bool Delete(Posts entity)
        {
            _db.Posts.Remove(entity);
            return Save();
        }

        public ICollection<Posts> FindAll()
        {
            var result = _db.Posts.Include(x=>x.User).Include(x=>x.Category).ToList();
            return result;
        }

        public Posts FindById(int id)
        {
            return _db.Posts.Find(id);
        }

        public ICollection<Categories> GetCategoryForPost(int postid)
        {
            var result = FindAll().Where(x => x.Id == postid).Select(x => x.Category).ToList();
            return result;
        }

        public int GetLastedId()
        {
            throw new NotImplementedException();
        }

        public ICollection<Posts> GetLastestPost(int take)
        {
            var result = FindAll().OrderByDescending(x => x.PostOn).Where(x=>x.Published==true).Take(take).ToList();
            return result;
        }

        public Posts GetPostDetail(string year, string month, string seoUrl)
        {
          
            var result = FindAll().FirstOrDefault(x => x.PostOn.Year.Equals(Convert.ToInt32(year)) && x.PostOn.Month.Equals(Convert.ToInt32(month)) && x.UrlSlug == seoUrl);
            return result;
        }

        public ICollection<Posts> GetPostHighestViewCount(int take)
        {
            var result = FindAll().OrderByDescending(x => x.ViewCount).Where(x => x.Published == true).Take(take).ToList();
            return result;
        }

        public ICollection<Posts> GetPostsByCategoryUrlSlug(string cateurl)
        {
            var result = FindAll().Where(x => x.Category.UrlSlug.Equals(cateurl) && x.Published == true).ToList();
            return result;
        }

        public ICollection<Posts> GetPostsByUser(string userid)
        {
            var result = FindAll().Where(x => x.UserId.Equals(userid)).ToList();
            return result;
        }

        public bool isExist(int id)
        {
            var exists = _db.Posts.Any(x => x.Id.Equals(id));
            return exists;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(Posts entity)
        {
            _db.Posts.Update(entity);
            return Save();
        }
    }
}
