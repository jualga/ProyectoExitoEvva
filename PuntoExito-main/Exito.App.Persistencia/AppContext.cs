using Microsoft.EntityFrameworkCore;
using Exito.App.Dominio;


namespace Exito.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Consola> Consolas { get; set; }
        public DbSet<Control> Controles { get; set; }
        public DbSet<VideoJuego> VideoJuegos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<TypoDisco> TypoDiscos { get; set; }
        // public DbSet<VentaDetalle> VentaDetalles { get; set; }
        // public DbSet<CompraDetalle> CompraDetalles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {

            if (!builder.IsConfigured)
            {
                builder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = ExitoAppV6");
            }
        }

    }

}