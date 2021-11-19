using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FA.JustBlog.Web.Data;

namespace FA.JustBlog.Web.Contract
{
    public interface IPostTagMapRepository : IRepository<PostTagMap>
    {

        ICollection<Tags> GetTagsByPost(int postid);

        ICollection<Posts> GetPostsByTagUrlSlug(string urlSlug);

        bool IsPostHaveTag(int postid);

        bool UpdateTag(int[] oldTag, int[] newTag, int postid);
    }
}
