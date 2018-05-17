using Presentacion.Interfaces;

namespace Presentacion.Presentadores
{
    public class IniciarSesionPresentador
    {
        private readonly IIniciarSesion _view;

        public IniciarSesionPresentador(IIniciarSesion view)
        {
            _view = view;
        }
    }
}
