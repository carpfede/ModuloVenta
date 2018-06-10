using Presentacion.Interfaces;
using Presentacion.Presentadores;
using System.Windows;
using System.Windows.Controls;

namespace Presentacion.Vistas
{
    public partial class MenuPrincipalView : Window, IMenuPrincipal
    {
        #region Members
        private MenuPrincipalPresentador _presentador;
        #endregion

        #region Constructor
        public MenuPrincipalView(MenuPrincipalPresentador presentador)
        {
            _presentador = presentador;
            _presentador.SetView(this);
            InitializeComponent();
        }
        #endregion

        #region IMenuPrincipal
        public void CargarFuncionalidad(UserControl control)
        {
            //Funcionalidades.RowDefinitions.Add();
        }

        public void CerrarSesion()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region PrivateMethods
        private void BtnAyuda_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMinimizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}