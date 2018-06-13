using Aplicacion.Servicios;
using Presentacion.Dto;
using Presentacion.Interfaces;
using Presentacion.Presentadores;
using System.Collections.Generic;
using System.Linq;
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
        public List<CategoriaMenuDto> MenuItems { get; private set; }
        #endregion

        #region Constructor
        public MenuPrincipalView(MenuPrincipalPresentador presentador)
        {
            _presentador = presentador;
            _presentador.SetView(this);
            _presentador.AgregarFuncionalidades();
            InitializeComponent();
            DataContext = this;
        }
        #endregion

        #region IMenuPrincipal
        public void CargarFuncionalidades(MenuItemBase[] funcionalidades)
        {
            var x = funcionalidades.Where(f => f.Jerarquia == "Usuarios").ToList();
            List<CategoriaMenuDto> categorias = new List<CategoriaMenuDto>()
            {
                new CategoriaMenuDto("Usuarios",funcionalidades.Where(f => f.Jerarquia == "Usuarios").ToList()),
                new CategoriaMenuDto("Empleados",funcionalidades.Where(f => f.Jerarquia == "Empleados").ToList()),
                new CategoriaMenuDto("Notificaciones",funcionalidades.Where(f => f.Jerarquia == "Notificaciones").ToList()),
                new CategoriaMenuDto("Mensajería",funcionalidades.Where(f => f.Jerarquia == "Mensajería").ToList())
            };
            MenuItems = categorias;
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