using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int? Documento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
