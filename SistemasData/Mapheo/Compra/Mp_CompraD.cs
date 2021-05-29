using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemasSociedad.compras;
using sistemasSociedad.bodega;
using sistemasSociedad.Usuarios;
using sistemasSociedad.ventas;

namespace SistemasData.Mapheo.Compra
{
    class Mp_CompraD : IEntityTypeConfiguration<CompraD>
    {
        public void Configure(EntityTypeBuilder<CompraD> builder)
        {
            builder.ToTable("CompraD")
                .HasKey(c => c.IDCompraD);
            builder.Property(c => c.cantidad);
            builder.Property(c => c.precioD);
            //fk de ingreso
            builder.HasOne(y => y.Compra)
                .WithOne();
            //fk de articulo
            builder.HasOne(y => y.item)
                .WithOne();
        }
    }
}
