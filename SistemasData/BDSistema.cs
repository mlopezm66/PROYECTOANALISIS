using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemasData.Mapheo.Bodega;
using SistemasData.Mapheo.Ventas;
using SistemasData.Mapheo.Compra;
using SistemasData.Mapheo.Usuarios;
using sistemaSociedad.compra;
using sistemaSociedad.Ventas;
using sistemaSociedad.Usu;
using sistemaData.Mapeo.Users;
using sistemaSociedad.Entidades.Wherehouse;


namespace SistemasData
{
    class BDSistema : DbContext


    {

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Item> item { get; set; }
        public DbSet<CompraD> CompraD { get; set; }
        public DbSet<VentaD> VentaD { get; set; }
        public DbSet<CompraH> CompraH { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usu> Usu { get; set; }
        public DbSet<Venta> Venta { get; set; }


        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new Mp_Categoria());
            modelBuilder.ApplyConfiguration(new Mp_Item());
            modelBuilder.ApplyConfiguration(new Mp_CompraD());
            modelBuilder.ApplyConfiguration(new Mp_VentaD());
            modelBuilder.ApplyConfiguration(new Mp_CompraH());
            modelBuilder.ApplyConfiguration(new Mp_Persona());
            modelBuilder.ApplyConfiguration(new Mp_rol());
            modelBuilder.ApplyConfiguration(new Mp_usu());
            modelBuilder.ApplyConfiguration(new Mp_VentaH());

        }


    }

}
