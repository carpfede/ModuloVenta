using System.Collections.Generic;
using System.Linq;

namespace Dominio.Entidades
{
    public class DetalleCompra
    {
        public int DetalleCompraId { get; set; }

        public virtual IEnumerable<Mercaderia> Mercaderias { get; set; }

        public double SubTotal()
        {
            return Mercaderias.Sum(m => m.Costo * m.Cantidad);
        }
    }
}