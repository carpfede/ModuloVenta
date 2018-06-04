using System.Linq;
using System.Security.Principal;
using Transversal.Seguridad;

namespace Presentacion.Seguridad
{
    public class IdentificacionUsuario : IIdentificacionUsuario, IPrincipal
    {
        public UsuarioPersonalizado Identity { private get; set; }

        IIdentity IPrincipal.Identity { get { return Identity; } }

        #region IIdentificacionUsuario

        public int UsuarioId { get; set; }
        public string UserName { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public bool IsInRole(string role) => Identity.Roles.Contains(role);
        #endregion
    }
}
