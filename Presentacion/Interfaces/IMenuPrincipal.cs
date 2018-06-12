using Aplicacion.Servicios;

namespace Presentacion.Interfaces
{
    public interface IMenuPrincipal : IView
    {
        void CargarFuncionalidades(MenuItemBase[] funcionalidades);
        void CerrarSesion();
    }
}
