using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IServiceBase<T> where T : class, IEntity, new()
    {
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
        Task<T> Get(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> include = null);
        Task<IEnumerable<T>> GetList(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> include = null);
    }
}
