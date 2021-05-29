using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasData.Mapheo.Ventas
{
    class Mp_VentaH : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("venta")
                 .HasKey(i => i.IDVenta);
            builder.Property(i => i.tipo)
            .HasMaxLength(20);
            builder.Property(i => i.serie)
                .HasMaxLength(7);
            builder.Property(i => i.numero)
                .HasMaxLength(10);
            builder.Property(i => i.fechaHora);
            builder.Property(i => i.impuesto);
            builder.Property(i => i.total);
            builder.Property(i => i.estado)
                .HasMaxLength(20);
            builder.HasOne(U => U.persona)
                .WithOne();
            builder.HasOne(u => u.Usu)
                .WithOne();
        }
    }
}