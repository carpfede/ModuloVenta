using Dominio.Entidades;
using System.Data.Entity;

namespace Datos
{
    public class Context : DbContext
    {
        public Context() : base("BDLeontinaCalzados")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Color> Colores { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetalleCompra> DetallesCompras { get; set; }
        public DbSet<DetalleMercaderia> DetallesMercaderias { get; set; }
        public DbSet<DetalleVenta> DetallesVentas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Mercaderia> Mercaderias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<RepresentanteProveedor> Representantes { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Talle> Talles { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }
}
