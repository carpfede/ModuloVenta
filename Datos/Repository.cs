using Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Datos
{
    public class Repository<T> : IRepository<T>, IDisposable
        where T : class
    {
        private readonly Context _context;

        public Repository(Context context)
        {
            _context = context;
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Attach(T item)
        {
            throw new NotImplementedException();
        }

        public void Attach(IEnumerable<T> items)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetFiltered(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Modify(T item)
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
