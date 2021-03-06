﻿namespace Dominio.Entidades
{
    public class Mercaderia
    {
        public int MercaderiaId { get; set; }
        public string Caracteristicas { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public double PrecioContado { get; set; }
        public double PrecioTarjeta { get; set; }
        public bool Disponible { get; set; }

        public virtual Talle Talle { get; set; }
        public virtual DetalleMercaderia DetalleMercaderia { get; set; }
    }
}