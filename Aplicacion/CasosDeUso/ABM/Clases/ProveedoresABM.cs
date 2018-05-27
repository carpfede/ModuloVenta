using Aplicacion.CasosDeUso.ABM.Interfaces;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Aplicacion.CasosDeUso.ABM.Clases
{
    public class ProveedoresABM : IProveedoresABM
    {
        public void Alta(Proveedor entity)
        {
            throw new System.NotImplementedException();
        }

        public void Baja(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Proveedor> Filtrar(Expression<Func<Proveedor, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Proveedor entity)
        {
            throw new System.NotImplementedException();
        }

        public Proveedor ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proveedor> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
