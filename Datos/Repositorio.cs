using Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Datos
{
    public class Repositorio<T> : IRepository<T>, IDisposable
        where T : class
    {
        private readonly Context _context;

        public Repositorio(Context context)
        {
            _context = context;
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Attach<T1>(T1 item)
        {
            throw new NotImplementedException();
        }

        public void Attach<T1>(IEnumerable<T1> items)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
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
    }
}
