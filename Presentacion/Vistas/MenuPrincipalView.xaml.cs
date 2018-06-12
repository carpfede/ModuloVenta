using Aplicacion.Servicios;
using Presentacion.Interfaces;
using Presentacion.Presentadores;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Presentacion.Vistas
{
    public partial class MenuPrincipalView : Window, IMenuPrincipal
    {
        #region Members
        private MenuPrincipalPresentador _presentador;
        public MenuItemBase[] MenuItems { get; private set; }
        #endregion

        #region Constructor
        public MenuPrincipalView(MenuPrincipalPresentador presentador)
        {
            _presentador = presentador;
            _presentador.SetView(this);
            InitializeComponent();
            DataContext = this;
            _presentador.AgregarFuncionalidades();
        }
        #endregion

        #region IMenuPrincipal
        public void CargarFuncionalidades(MenuItemBase[] funcionalidades)
        {
            MenuItems = funcionalidades;
        }

        public void CerrarSesion()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            Close();
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

        private void Item_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var dependencyObject = Mouse.Captured as DependencyObject;
            while (dependencyObject != null)
            {
                if (dependencyObject is ScrollBar) return;
                dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
            }

            MenuToggleButton.IsChecked = false;
        }
        #endregion


    }
}