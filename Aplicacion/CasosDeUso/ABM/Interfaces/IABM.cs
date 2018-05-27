using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Aplicacion.CasosDeUso.ABM.Interfaces
{
    public interface IABM<T>
        where T : class
    {
        void Alta(T entity);
        void Baja(int id);
        void Modificacion(T entity);
        T ObtenerPorId(int id);
        IEnumerable<T> Filtrar(Expression<Func<T, bool>> filter);
        IEnumerable<T> ObtenerTodos();
    }
}
