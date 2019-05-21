using Core.DataAccess.IBaseRepositories;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Core.DataAccess.BaseClasses.EntityFramework
{
    public class EFRepositoryBase<TEntity, TKey, TContext> : IRepository<TEntity, TKey>
        where TEntity : class,IEntity, new()
        where TContext : DbContext, new()
    {
        public readonly TContext _context;
        public readonly DbSet<TEntity> _dbSet;

        public EFRepositoryBase(DbContext context)
        {
            _context = (TContext)context;
            _dbSet = _context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            Save();
        }

        public int Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            return Save();
        }

        public int Delete(TKey id)
        {
            TEntity entity = GetById(id);
            return Delete(entity);

        }

        public int Delete(Expression<Func<TEntity, bool>> exp)
        {
            List<TEntity> silinecekler = _dbSet.Where(exp).ToList();
            _dbSet.RemoveRange(silinecekler);
            return Save();
        }

        public List<TEntity> Get(Expression<Func<TEntity, bool>> exp = null)
        {
            if (exp == null)
            {
                return _dbSet.ToList();
            }
            else
            {
                return _dbSet.Where(exp).ToList();
            }

        }

        public int Save()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return Save();
        }

        public TEntity GetById(TKey id)
        {
            return _dbSet.Find(id);
        }
    }
}