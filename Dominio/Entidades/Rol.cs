using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Roles")]
    public class Rol
    {
        public int RolId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
