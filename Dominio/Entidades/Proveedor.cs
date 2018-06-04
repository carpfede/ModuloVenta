using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Proveedor
    {
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public int CodigoPostal { get; set; }
        public string Email { get; set; }
        public long Telefono { get; set; }

        public ICollection<Marca> Marcas { get; set; }
    }
}
