using System.Collections.Generic;
using System.Windows.Controls;

namespace Presentacion.Interfaces
{
    public interface IMenuPrincipal
    {
        void CargarFuncionalidad(UserControl control);
        void CerrarSesion();
    }
}
