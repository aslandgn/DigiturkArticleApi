using Business.Abstract;
using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public abstract class ConcreteBase<T, R> : IServiceBase<T> where T : class, IEntity, new() where R : IRepository<T>
    {
        protected internal R _abstractDataAccess;

        public Task<T> Add(T entity)
        {
            return _abstractDataAccess.Add(entity);
        }

        public Task Delete(T entity)
        {
            return _abstractDataAccess.Delete(entity);
        }

        public Task<T> Get(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> include = null)
        {
            return _abstractDataAccess.Get(filter);
        }

        public Task<IEnumerable<T>> GetList(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> include = null)
        {
            return _abstractDataAccess.GetList(filter);
        }

        public Task<T> Update(T entity)
        {
            return _abstractDataAccess.Update(entity);
        }
    }
}
