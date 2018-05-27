namespace Dominio.Entidades
{
    public class RepresentanteProveedor
    {
        public int RepresentanteProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public int CodigoPostal { get; set; }
        public string Email { get; set; }
        public long Telefono { get; set; }
    }
}
