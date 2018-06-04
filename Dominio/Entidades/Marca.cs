using Dominio.Enums;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Nombre { get; set; }
        public EProvincia Provincia { get; set; }

        public ICollection<Proveedor> Proveedores { get; set; }
    }
}
