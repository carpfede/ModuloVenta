using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Dominio.Repositorios
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : class
    {
        void Add(TEntity item);
        void Remove(TEntity item);
        void Modify(TEntity item);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter);
        IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes);
        void Attach(TEntity item);
        void Attach(IEnumerable<TEntity> items);
    }
}
