using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Colores")]
    public class Color
    {
        public int ColorId { get; set; }
        public string NombreColor { get; set; }
        public string Descripcion { get; set; }
    }
}
