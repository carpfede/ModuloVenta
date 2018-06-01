using System;
using Presentacion.Interfaces;
using Aplicacion.CasosDeUso.Interfaces;

namespace Presentacion.Presentadores
{
    public class IniciarSesionPresentador : IPresenter<IIniciarSesion>
    {
        private IIniciarSesion _view;
        private IInicioSesion _inicioSesion;

        public IniciarSesionPresentador(IInicioSesion inicioSesion)
        {
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