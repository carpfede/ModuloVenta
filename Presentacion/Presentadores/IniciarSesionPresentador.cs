using Aplicacion.CasosDeUso.Interfaces;
using Aplicacion.Servicios;
using Presentacion.Interfaces;
using Presentacion.Seguridad;
using System;
using System.Threading;

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
            var user = _inicioSesion.AutenticarUsuario(_view.Usuario, _view.Contraseña);

            IdentificacionUsuario customPrincipal = Thread.CurrentPrincipal as IdentificacionUsuario;
            if (customPrincipal == null)
                throw new ArgumentException("The application's default thread principal must be set to a CustomPrincipal object on startup.");

            //Authenticate the user
            customPrincipal.Identity = new UsuarioPersonalizado(user.Username, user.Email, user.Roles);
        }
    }
}