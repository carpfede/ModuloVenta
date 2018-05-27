using Dominio.Dto;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Aplicacion.CasosDeUso.Interfaces
{
    public interface IRealizarVenta
    {
        IniciarVentaDto IniciarVenta();
        IEnumerable<Mercaderia> FiltrarMercaderia(Expression<Func<Mercaderia, bool>> filter);
        void CargarVenta(Venta venta);
    }
}
