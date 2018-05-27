using Aplicacion.CasosDeUso.ABM.Interfaces;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Aplicacion.CasosDeUso.ABM.Clases
{
    public class ColoresABM : IColoresABM
    {
        public void Alta(Color entity)
        {
            throw new System.NotImplementedException();
        }

        public void Baja(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Color> Filtrar(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Color entity)
        {
            throw new System.NotImplementedException();
        }

        public Color ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Color> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
