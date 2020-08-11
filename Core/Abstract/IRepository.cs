using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Abstract
{
    public interface IRepository<T> where T : class, new()
    {
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
        Task<IEnumerable<T>> GetList(Expression<Func<T,bool>> filter = null);
        Task<T> Get(Expression<Func<T, bool>> filter = null);
    }
}
