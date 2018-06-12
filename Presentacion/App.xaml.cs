using Presentacion.IoC;
using Presentacion.Seguridad;
using System;
using System.Security.Principal;
using System.Windows;
using Transversal.IoC;
using Transversal.Seguridad;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IoCFactory.Instance.SetContainer(new IoCUnityContainer());
            IdentificacionServicio.Instance.SetUserIdentification(new IdentificacionUsuario());
            AppDomain.CurrentDomain.SetThreadPrincipal((IPrincipal)IdentificacionServicio.Instance.UserIdentification);
            ComposeObjects();
            Current.MainWindow.Show();
        }

        private static void ComposeObjects()
        {
            Current.MainWindow = IoCFactory.Instance.CurrentContainer.Resolve<Vistas.IniciarSesionView>();
        }
    }
}
