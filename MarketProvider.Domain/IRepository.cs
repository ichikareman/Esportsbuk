using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace MarketProvider.Domain
{
    public interface IRepository<TEntity>
    {
        TEntity Get(int id);

        IQueryable<TEntity> Query();

        IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] includeExpression);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        int CommitChanges();
    }
}
