using Aplicacion.CasosDeUso.ABM.Interfaces;
using Aplicacion.Servicios;
using Presentacion.Interfaces;
using System.Linq;
using System.Security.Permissions;
using Transversal.Seguridad;

namespace Presentacion.Presentadores
{
    public class MenuPrincipalPresentador : IPresenter<IMenuPrincipal>
    {
        private IMenuPrincipal _view;
        private readonly IRolesABM _roles;
        private readonly IFuncionalidadService _service;

        public MenuPrincipalPresentador(IFuncionalidadService service, IRolesABM roles)
        {
            _service = service;
            _roles = roles;
        }

        public void SetView(IMenuPrincipal view)
        {
            _view = view;
        }

        [PrincipalPermission(SecurityAction.Demand, Authenticated = true)]
        public void AgregarFuncionalidades()
        {
            var roles = IdentificacionServicio.User.Roles;

            var items = _service.Funcionalidades(roles.ToList());

            _view.CargarFuncionalidades(items.ToArray());
        }
    }
}
