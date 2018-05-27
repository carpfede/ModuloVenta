using Dominio.Entidades;
using System.Collections.Generic;

namespace Aplicacion.CasosDeUso.Interfaces
{
    public interface IAltaStock
    {
        void AltaMercaderia(IEnumerable<Mercaderia> mercaderias);
        void ActualizarPrecio(double tarjeta, double efectivo, int detalleMercaderiaId);
    }
}
