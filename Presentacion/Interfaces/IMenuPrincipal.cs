using System.Collections.Generic;
using System.Windows.Controls;

namespace Presentacion.Interfaces
{
    public interface IMenuPrincipal : IView
    {
        void CargarFuncionalidad(UserControl control);
        void CerrarSesion();
    }
}
