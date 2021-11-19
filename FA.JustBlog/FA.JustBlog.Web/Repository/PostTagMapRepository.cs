using FA.JustBlog.Web.Contract;
using FA.JustBlog.Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Repository
{
    public class PostTagMapRepository : IPostTagMapRepository
    {
        public readonly ApplicationDbContext _db;

        public PostTagMapRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(PostTagMap entity)
        {
            _db.PostTagMaps.Add(entity);
            return Save();
        }

        public bool Delete(PostTagMap entity)
        {
            _db.PostTagMaps.Remove(entity);
            return Save();
        }

        public ICollection<PostTagMap> FindAll()
        {
            var result = _db.PostTagMaps.Include(x => x.Post).Include(x=>x.Tags).ToList();
            return result;
        }

        public PostTagMap FindById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Posts> GetPostsByTagUrlSlug(string urlSlug)
        {
            var result = FindAll().Where(x => x.Tags.UrlSlug.Equals(urlSlug) && x.Post.Published==true)
                .Select(x => x.Post).ToList();
            return result;
        }

        public ICollection<Tags> GetTagsByPost(int postid)
        {
            var result = _db.PostTagMaps.Where(x => x.PostId == postid)
                .Select(x =>x.Tags).ToList();
            return result;
        }

        public bool isExist(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsPostHaveTag(int postid)
        {
            var result = _db.PostTagMaps.Any(x => x.PostId == postid);
            return result;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(PostTagMap entity)
        {
            _db.PostTagMaps.Update(entity);
            return Save();
        }

        public bool UpdateTag(int[] oldTag, int[] newTag, int postid)
        {
            throw new NotImplementedException();
        }
    }
}
