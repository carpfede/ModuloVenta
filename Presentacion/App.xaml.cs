using System.Windows;

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
            ComposeObjects();
            Current.MainWindow.Show();
        }

        private static void ComposeObjects()
        {

            Current.MainWindow = new Vistas.IniciarSesionView
            {
                Title = "Iniciar Sesion"
            };
        }
    }
}
