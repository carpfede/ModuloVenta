using Presentacion.Interfaces;
using Presentacion.Presentadores;
using System.Windows;
using System.Windows.Controls;

namespace Presentacion.Vistas
{
    public partial class MenuPrincipalView : Window, IMenuPrincipal
    {
        private MenuPrincipalPresentador _presentador;

        public MenuPrincipalView(MenuPrincipalPresentador presentador)
        {
            _presentador = presentador;
            _presentador.SetView(this);
            InitializeComponent();
        }

        public void CargarFuncionalidad(UserControl control)
        {
            //Funcionalidades.RowDefinitions.Add();
        }

        public void CerrarSesion()
        {
            throw new System.NotImplementedException();
        }

        private void BtnAyuda_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMinimizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
