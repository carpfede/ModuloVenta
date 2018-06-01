using Transversal;

namespace Presentacion.Interfaces
{
    public interface IIniciarSesion : IView
    {
        string Usuario { get; }
        string Contraseña { get; }
        void AccesoPermitido(Sesion sesion);
    }
}
