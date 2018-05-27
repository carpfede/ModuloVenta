using Dominio.Enums;

namespace Dominio.Entidades
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Nombre { get; set; }
        public EProvincia Provincia { get; set; }
    }
}
