using Presentacion.Dto;
using Presentacion.Interfaces;
using Presentacion.Seguridad;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Controls;

namespace Presentacion.Presentadores
{
    public class MenuPrincipalPresentador : IPresenter<IMenuPrincipal>
    {
        private IMenuPrincipal _view;

        public void SetView(IMenuPrincipal view)
        {
            _view = view;
        }

        [PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public void AgregarFuncionalidades()
        {
            if (Thread.CurrentPrincipal.IsInRole("Vendedor"))
                FuncionalidadesVendedor();
            if (Thread.CurrentPrincipal.IsInRole("Repositor"))
                FuncionalidadesRepositor();
            if (Thread.CurrentPrincipal.IsInRole("Administrador"))
                FuncionalidadesAdministrador();
        }

        private void FuncionalidadesAdministrador()
        {
            _view.CargarFuncionalidades(
                new ItemMenuDto[] {
                    new ItemMenuDto("Usuarios",new UserControl{ }),
                    new ItemMenuDto("Empleados",new UserControl{ }),
                    new ItemMenuDto("Notificaciones",new UserControl{ }),
                    new ItemMenuDto("Mensajería",new UserControl{ })
                });
        }

        private void FuncionalidadesRepositor()
        {
        }

        private void FuncionalidadesVendedor()
        {
        }
    }
}
