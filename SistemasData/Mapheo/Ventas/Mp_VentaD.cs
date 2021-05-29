using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasSociedad.Ventas;
using System.Threading.Tasks;

namespace SistemasData.Mapheo.Ventas
{
    class Mp_VentaD : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("detalleventa")
                 .HasKey(d => d.IDVentaH);
            builder.Property(d => d.cantidad);
            builder.Property(d => d.precioU);
            builder.Property(d => d.descuento);
            builder.HasOne(x => x.Ventas)
                .WithOne();
            builder.HasOne(x => x.item)
                .WithOne();
        }
    }
}