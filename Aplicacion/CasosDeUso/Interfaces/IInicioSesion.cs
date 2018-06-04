using Dominio.Entidades;

namespace Aplicacion.CasosDeUso.Interfaces
{
    public interface IInicioSesion
    {
        Usuario AutenticarUsuario(string usuario,string contraseña);
    }
}
