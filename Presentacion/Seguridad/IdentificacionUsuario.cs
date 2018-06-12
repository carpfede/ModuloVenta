using System.Linq;
using System.Security.Principal;
using Transversal.Seguridad;

namespace Presentacion.Seguridad
{
    public class IdentificacionUsuario : IPrincipal, IUsuarioPersonalizado
    {
        public UsuarioPersonalizado Identity { private get; set; }

        public string Name => Identity.Name;

        public string[] Roles => Identity.Roles;

        IIdentity IPrincipal.Identity { get { return Identity; } }

        public bool IsInRole(string role)
        {
            return Identity?.Roles?.Contains(role) ?? false;
        }
    }
}
