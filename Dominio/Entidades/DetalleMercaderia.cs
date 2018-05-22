namespace Dominio.Entidades
{
    public class DetalleMercaderia
    {
        public int DetalleMercaderiaId { get; set; }
        public string Descripcion { get; set; }
        public string Articulo { get; set; }

        public virtual Color Color { get; set; }
    }
}
