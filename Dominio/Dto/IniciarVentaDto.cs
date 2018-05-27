using Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Dto
{
    public class IniciarVentaDto
    {
        public IEnumerable<Mercaderia> Mercaderias { get; set; }
    }
}