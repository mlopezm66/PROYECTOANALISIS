using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasSociedad.Compra;
using SistemasSociedad.Bodega;

namespace SistemasData.Mapheo.Bodega
{
    class Mp_Item : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item")
                .HasKey(b => b.IDitem);
            builder.Property(b => b.codigo)
              .HasMaxLength(50);
            builder.Property(b => b.nombre)
                .HasMaxLength(50);
            builder.Property(b => b.precioU);
            builder.Property(b => b.Existencias);
            builder.Property(b => b.Descripcion)
                .HasMaxLength(256);
            builder.Property(b => b.condicion);
            builder.HasOne(z => z.categoria)
                .WithOne();
        }
    }
}

