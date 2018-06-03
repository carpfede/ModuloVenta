using Aplicacion.CasosDeUso.Interfaces;
using Aplicacion.Servicios;
using Presentacion.Interfaces;

namespace Presentacion.Presentadores
{
    public class IniciarSesionPresentador : IPresenter<IIniciarSesion>
    {
        private IIniciarSesion _view;
        private IInicioSesion _inicioSesion;
        private INotificationService _notification;

        public IniciarSesionPresentador(IInicioSesion inicioSesion, INotificationService notificationService)
        {
            _notification = notificationService;
            _inicioSesion = inicioSesion;
        }

        public void SetView(IIniciarSesion view)
        {
            _view = view;
        }

        public void IngresarAlSistema()
        {
            _inicioSesion.AutenticarUsuario(_view.Usuario, _view.Contraseña);
        }
    }
}