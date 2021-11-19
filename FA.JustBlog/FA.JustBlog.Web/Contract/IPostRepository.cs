using FA.JustBlog.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Contract
{
    public interface IPostRepository : IRepository<Posts>
    {
        ICollection<Posts> GetPostHighestViewCount(int take);

        ICollection<Posts> GetLastestPost(int take);

        Posts GetPostDetail(string year, string month, string seoUrl);

        ICollection<Categories> GetCategoryForPost(int postid);

        ICollection<Posts> GetPostsByCategoryUrlSlug(string catename);

        int GetLastedId();

        ICollection<Posts> GetPostsByUser(string userid);
    }
}
