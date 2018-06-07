using Aplicacion.CasosDeUso.Interfaces;
using Dominio.Entidades;
using Dominio.Repositorios;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Aplicacion.CasosDeUso.Clases
{
    public class InicioSesion : IInicioSesion
    {
        private readonly IRepository<Usuario> _repositorioUsuarios;

        public InicioSesion(IRepository<Usuario> repositorioUsuarios)
        {
            _repositorioUsuarios = repositorioUsuarios;
        }

        public Usuario AutenticarUsuario(string usuario, string contraseña)
        {
            string hash = CalculateHash(contraseña, usuario);
            return _repositorioUsuarios.GetFiltered(u =>
                    u.PasswordHash.Equals(hash) && u.UserName.Equals(usuario))
                    .FirstOrDefault();
        }

        private string CalculateHash(string clearTextPassword, string salt)
        {
            byte[] saltedHashBytes = Encoding.UTF8.GetBytes(clearTextPassword + salt);
            HashAlgorithm algorithm = new SHA256Managed();
            byte[] hash = algorithm.ComputeHash(saltedHashBytes);
            return Convert.ToBase64String(hash);
        }
    }
}
