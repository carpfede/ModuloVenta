using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Disabled { get; set; }

        public virtual ICollection<Rol> Roles { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
