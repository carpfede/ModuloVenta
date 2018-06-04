using System.Collections.Generic;
using System.Security.Principal;

namespace Presentacion.Seguridad
{
    public class UsuarioPersonalizado : IIdentity
    {

        int UsuarioId { get; set; }
        string Apellido { get; set; }
        string Nombre { get; set; }
        public string Name { get; private set; }
        public IEnumerable<string> Roles { get; private set; }
        public string AuthenticationType { get { return "Custom authentication"; } }
        public bool IsAuthenticated { get { return !string.IsNullOrEmpty(Name); } }
    }
}
