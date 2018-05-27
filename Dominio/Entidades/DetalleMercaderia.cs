namespace Dominio.Entidades
{
    public class DetalleMercaderia
    {
        public int DetalleMercaderiaId { get; set; }
        public string Descripcion { get; set; }
        public string Articulo { get; set; }
        /// <summary>
        ///    Este campo sirve para poder ubicar con mayor facilidad la mercaderia fisicamente
        /// </summary>
        public string TipoDeCaja { get; set; }

        public virtual Color Color { get; set; }
        public virtual Marca Marca { get; set; }

    }
}
