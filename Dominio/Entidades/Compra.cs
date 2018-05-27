using System;

namespace Dominio.Entidades
{
    public class Compra
    {
        public int CompraId { get; set; }
        public DateTime Fecha { get; set; }
        public double Importe { get { return Importe; } set { Importe = DetalleCompra.SubTotal() - Bonificacion;  } }
        public double Bonificacion { get; set; }
        public string ConceptoBonificacion { get; set; }

        public virtual DetalleCompra DetalleCompra { get; set; }
        public virtual RepresentanteProveedor RepresentanteProveedor { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}