using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccses.Repos.GenericRepo
{
    public interface IGenericRepository<T> where T : class
    {
        void  Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> where);

        void UpdateAll(List<T> entities);
    }
}
