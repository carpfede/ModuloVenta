using System;

namespace Dominio.Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public double TotalEfectivo { get { return TotalEfectivo; } set { TotalEfectivo = DetalleVenta.SubTotal(true); } }
        public double TotalTarjeta { get { return TotalTarjeta; } set { TotalTarjeta = DetalleVenta.SubTotal(false); } }
        public double Descuento { get; set; }
        public double Recargo { get; set; }
        public double ConceptoDescuento { get; set; }
        public double ConceptoRecargo { get; set; }

        public virtual DetalleVenta DetalleVenta { get; set; }
        public virtual Sucursal Sucursal { get; set; }
    }
}
