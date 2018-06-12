using Aplicacion.CasosDeUso.ABM.Interfaces;
using Dominio.Entidades;
using Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Aplicacion.CasosDeUso.ABM.Clases
{
    public class RolesABM : IRolesABM
    {
        private readonly IRepository<Rol> _repositorioUsuarios;

        public RolesABM(IRepository<Rol> repository)
        {
            _repositorioUsuarios = repository;
        }

        public void Alta(Rol entity)
        {
            throw new System.NotImplementedException();
        }

        public void Baja(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Rol> Filtrar(Expression<Func<Rol, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Rol entity)
        {
            throw new System.NotImplementedException();
        }

        public Rol ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Rol ObtenerPorNombre(string nombre)
        {
            return _repositorioUsuarios.GetFiltered(r => r.Nombre == nombre).FirstOrDefault();
        }

        public IEnumerable<Rol> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
