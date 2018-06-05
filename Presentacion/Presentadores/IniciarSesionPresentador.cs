using Aplicacion.CasosDeUso.Interfaces;
using Aplicacion.Servicios;
using Dominio.Enums;
using Presentacion.Interfaces;
using Presentacion.Seguridad;
using System;
using System.Linq;
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
            if (user == null)
            {
                _notification.Notify("Error de logeo", "El usuario o contraseña no son correctos.", EToastColor.ErrorColor);
                return;
            }
            if (!(Thread.CurrentPrincipal is IdentificacionUsuario customPrincipal))
                throw new ArgumentException("The application's default thread principal must be set to a CustomPrincipal object on startup.");
            var roles = user.Roles.Select(u => u.Nombre);
            //Authenticate the user
            customPrincipal.Identity = new UsuarioPersonalizado(user.UserName, roles.ToArray());
        }
    }
}