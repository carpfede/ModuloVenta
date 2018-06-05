using System.Linq;
using System.Security.Principal;

namespace Presentacion.Seguridad
{
    public class IdentificacionUsuario : IPrincipal
    {
        public UsuarioPersonalizado Identity { private get; set; }

        IIdentity IPrincipal.Identity { get { return Identity; } }

        public bool IsInRole(string role)
        {
            return Identity?.Roles?.Contains(role) ?? false;
        }
    }
}
