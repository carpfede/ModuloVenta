namespace Aplicacion.Servicios
{
    public class MenuItemBase
    {
        public virtual string Nombre { get; set; }
        public virtual string Jerarquia { get; set; }
        public virtual object Content { get; set; }
    }
}
