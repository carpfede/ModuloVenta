using Aplicacion.CasosDeUso.ABM.Interfaces;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Aplicacion.CasosDeUso.ABM.Clases
{
    public class TallesABM : ITallesABM
    {
        public void Alta(Talle entity)
        {
            throw new System.NotImplementedException();
        }

        public void Baja(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Talle> Filtrar(Expression<Func<Talle, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Talle entity)
        {
            throw new System.NotImplementedException();
        }

        public Talle ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Talle> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
