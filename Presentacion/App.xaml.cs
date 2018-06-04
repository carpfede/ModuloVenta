using Presentacion.IoC;
using Presentacion.Seguridad;
using System;
using System.Windows;
using Transversal.IoC;

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
            AppDomain.CurrentDomain.SetThreadPrincipal(new IdentificacionUsuario());
            ComposeObjects();
            Current.MainWindow.Show();
        }

        private static void ComposeObjects()
        {
            Current.MainWindow = IoCFactory.Instance.CurrentContainer.Resolve<Vistas.IniciarSesionView>();
        }
    }
}
