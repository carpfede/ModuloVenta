using Dominio.Enums;

namespace Dominio.Entidades
{
    public class Sucursal
    {
        public int SucursalId { get; set; }
        public int PuntoVenta { get; set; }
        public string Domicilio { get; set; }
        public EProvincia Provincia { get; set; }
    }
}
