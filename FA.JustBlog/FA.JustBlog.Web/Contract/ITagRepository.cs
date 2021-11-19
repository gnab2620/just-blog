using FA.JustBlog.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Contract
{
    public interface ITagRepository : IRepository<Tags>
    {
        ICollection<Tags> GetPopularTag(int take);

        Tags FindByUrlSlug(string urlSlug);
    }
}
