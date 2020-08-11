using Core.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Concrete.ORM
{
    public class EfRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        protected DbContext dbContext;
        public async Task<T> Add(T entity)
        {
            var addedEntity = dbContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(T entity)
        {
            var addedEntity = dbContext.Entry(entity);
            addedEntity.State = EntityState.Deleted;
            await dbContext.SaveChangesAsync();
        }

        public async Task<T> Get(Expression<Func<T, bool>> filter)
        {
            T item;
            item = await dbContext.Set<T>().Where(filter).FirstOrDefaultAsync();
            return item;
        }

        public async Task<IEnumerable<T>> GetList(Expression<Func<T, bool>> filter)
        {
            IEnumerable<T> itemList;
            if (filter == null)
            {
                filter = x => true;
            }
            itemList = await dbContext.Set<T>().Where(filter).ToListAsync();
            return itemList;
        }

        public async Task<T> Update(T entity)
        {
            var addedEntity = dbContext.Entry(entity);
            addedEntity.State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return entity;
        }

    }
}
