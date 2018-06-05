using Dominio.Entidades;
using System.Collections.Generic;
using System.Security.Principal;

namespace Presentacion.Seguridad
{
    public class UsuarioPersonalizado : IIdentity
    {
        public UsuarioPersonalizado(string name, string[] roles)
        {
            Name = name;
            Roles = roles;
        }

        public string Name { get; private set; }
        public string[] Roles { get; private set; }
        public string AuthenticationType { get { return "Custom authentication"; } }
        public bool IsAuthenticated { get { return !string.IsNullOrEmpty(Name); } }
    }
}
