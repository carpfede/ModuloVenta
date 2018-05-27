using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Aplicacion.CasosDeUso.Interfaces;
using Dominio.Dto;
using Dominio.Entidades;

namespace Aplicacion.CasosDeUso.Clases
{
    public class RealizarVenta : IRealizarVenta
    {
        public void CargarVenta(Venta venta)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Mercaderia> FiltrarMercaderia(Expression<Func<Mercaderia, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IniciarVentaDto IniciarVenta()
        {
            throw new NotImplementedException();
        }
    }
}
