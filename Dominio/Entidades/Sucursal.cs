using Dominio.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Sucursales")]
    public class Sucursal
    {
        public int SucursalId { get; set; }
        public int PuntoVenta { get; set; }
        public string Domicilio { get; set; }
        public EProvincia Provincia { get; set; }
    }
}
