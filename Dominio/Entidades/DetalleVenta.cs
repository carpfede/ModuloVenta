using System.Collections.Generic;
using System.Linq;

namespace Dominio.Entidades
{
    public class DetalleVenta
    {
        public int DetalleVentaId { get; set; }

        public virtual IEnumerable<Mercaderia> Mercaderias { get; set; }

        public double SubTotal(bool esContado)
        {
            if (esContado)
                return Mercaderias.Sum(m => m.PrecioContado * m.Cantidad);
            return Mercaderias.Sum(m => m.PrecioTarjeta * m.Cantidad);
        }
    }
}
