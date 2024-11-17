using Microsoft.AspNetCore.Routing;
using Revit.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        private readonly ApplicationDbContext _dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public TEntity Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            var count = await _dbContext.SaveChangesAsync();
            return entity;
        }


        public int AddRange(List<TEntity> entities)
        {
            _dbContext.Set<TEntity>().AddRange(entities);
            return _dbContext.SaveChanges();
        }

        public async Task<int> AddRangeAsync(List<TEntity> entities)
        {
            _dbContext.Set<TEntity>().AddRange(entities);
            return await _dbContext.SaveChangesAsync();
        }

        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            var count = _dbContext.Set<TEntity>().Count(predicate);
            return count;
        }

        public int Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            return _dbContext.SaveChanges();
        }

        public int Delete(Expression<Func<TEntity, bool>> predicate)
        {
            var deleteItems = _dbContext.Set<TEntity>().Where(predicate);
            _dbContext.Set<TEntity>().RemoveRange(deleteItems);
            return _dbContext.SaveChanges();
        }

        public TEntity? Get(long? id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public async Task<TEntity> GetAsync(long? id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate).AsQueryable();
        }

        public IEnumerable<TEntity> GetPagedList(int skip, int take, IQueryable<TEntity> queryable)
        {
            return queryable.Skip(skip).Take(take).ToList();
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return _dbContext.Set<TEntity>().AsQueryable();
        }

        public T Query<T>(Func<IQueryable<TEntity>, T> queryMethod)
        {

            return queryMethod.Invoke(this.GetQueryable());
        }

        public int Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            return _dbContext.SaveChanges();
        }
    }
}
