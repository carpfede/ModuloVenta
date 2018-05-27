using Dominio.Dto;
using Dominio.Entidades;
using System.Collections.Generic;

namespace Aplicacion.CasosDeUso.Interfaces
{
    public interface IProcesarCompra
    {
        IniciarCompraDto IniciarCompra();
        IEnumerable<DetalleMercaderia> BuscarDetalles(string articulo);
        void CargarCompra(Compra compra);
    }
}
