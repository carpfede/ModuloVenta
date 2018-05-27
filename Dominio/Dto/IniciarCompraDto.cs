using Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Dto
{
    public class IniciarCompraDto
    {
        IEnumerable<Proveedor> Proveedores { get; set; }
        IEnumerable<Talle> Talles { get; set; }
        IEnumerable<Color> Colores { get; set; }
        IEnumerable<Marca> Marcas { get; set; }
    }
}
