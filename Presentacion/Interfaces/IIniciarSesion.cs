using Transversal;

namespace Presentacion.Interfaces
{
    public interface IIniciarSesion : IView
    {
        void AccesoPermitido(Sesion sesion);
    }
}
