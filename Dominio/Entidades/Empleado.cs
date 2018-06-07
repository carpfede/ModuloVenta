using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Empleados")]
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Documento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
