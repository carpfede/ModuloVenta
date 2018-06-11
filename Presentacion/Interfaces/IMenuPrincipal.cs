using Presentacion.Dto;

namespace Presentacion.Interfaces
{
    public interface IMenuPrincipal : IView
    {
        void CargarFuncionalidades(ItemMenuDto[] funcionalidades);
        void CerrarSesion();
    }
}
