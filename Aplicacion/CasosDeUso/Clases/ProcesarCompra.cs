using System.Collections.Generic;
using Aplicacion.CasosDeUso.Interfaces;
using Dominio.Dto;
using Dominio.Entidades;

namespace Aplicacion.CasosDeUso.Clases
{
    public class ProcesarCompra : IProcesarCompra
    {
        public IEnumerable<DetalleMercaderia> BuscarDetalles(string articulo)
        {
            throw new System.NotImplementedException();
        }

        public void CargarCompra(Compra compra)
        {
            throw new System.NotImplementedException();
        }

        public IniciarCompraDto IniciarCompra()
        {
            throw new System.NotImplementedException();
        }
    }
}
