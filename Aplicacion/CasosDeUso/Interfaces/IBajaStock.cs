using Dominio.Entidades;
using System.Collections.Generic;

namespace Aplicacion.CasosDeUso.Interfaces
{
    public interface IBajaStock
    {
        void BajaMercaderia(IEnumerable<Mercaderia> mercaderias);
    }
}
