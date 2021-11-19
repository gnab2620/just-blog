using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FA.JustBlog.Web.Contract
{
    public interface IRepository<T> where T : class
    {
        ICollection<T> FindAll();

        T FindById(int id);
        bool isExist(int id);
        bool Update(T entity);
        bool Create(T entity);
        bool Delete(T entity);

        bool Save();
    }
}
