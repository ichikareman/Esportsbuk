using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using System.Linq.Expressions;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace MarketProvider.Domain.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ISportsbookDbContext _context;
        private readonly IDbSet<TEntity> _dbSet;

        public Repository(ISportsbookDbContext context)
        {
            _context = context;
            _dbSet = ((DbContext)_context).Set<TEntity>();
        }

        public IDbTransaction BeginTransaction()
        {
            if (((DbContext)_context).Database.Connection.State != ConnectionState.Open)
            {
                ((DbContext)_context).Database.Connection.Open();
            }

            return ((DbContext)_context).Database.Connection.BeginTransaction();
        }

        public TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<TEntity> Query()
        {
            return _dbSet.AsQueryable();
        }

        public IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] includeExpressions)
        {
            return includeExpressions.Aggregate(Query(), (current, include) => current.Include(include));
        }

        public IQueryable<TEntity> Query(params string[] includes)
        {
            var query = _dbSet.AsQueryable();

            foreach (var inc in includes)
            {
                query = _dbSet.Include(inc);
            }

            return query;
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            ((DbContext)_context).Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            if (((DbContext)_context).Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public int CommitChanges()
        {
            try
            {
                return ((DbContext)_context).SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }

            return 0;
        }
    }
}
