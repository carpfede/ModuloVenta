using Aplicacion.CasosDeUso.ABM.Interfaces;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Aplicacion.CasosDeUso.ABM.Clases
{
    public class EmpleadosABM : IEmpleadosABM
    {
        public void Alta(Empleado entity)
        {
            throw new System.NotImplementedException();
        }

        public void Baja(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Empleado> Filtrar(Expression<Func<Empleado, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Empleado entity)
        {
            throw new System.NotImplementedException();
        }

        public Empleado ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleado> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
