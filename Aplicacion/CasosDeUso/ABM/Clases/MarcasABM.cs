using Aplicacion.CasosDeUso.ABM.Interfaces;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Aplicacion.CasosDeUso.ABM.Clases
{
    public class MarcasABM : IMarcasABM
    {
        public void Alta(Marca entity)
        {
            throw new System.NotImplementedException();
        }

        public void Baja(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Marca> Filtrar(Expression<Func<Marca, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Marca entity)
        {
            throw new System.NotImplementedException();
        }

        public Marca ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Marca> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
