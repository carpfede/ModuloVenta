using Presentacion.Interfaces;

namespace Presentacion.Presentadores
{
    public class IniciarSesionPresentador : IPresenter<IIniciarSesion>
    {
        private IIniciarSesion _view;

        public void SetView(IIniciarSesion view)
        {
            _view = view;
        }
    }
}