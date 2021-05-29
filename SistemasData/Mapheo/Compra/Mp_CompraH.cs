using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sistemassociedad.compra;

namespace SistemasData.Mapheo.Compra
{
    class Mp_CompraH : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.ToTable("Compra")
            .HasKey(e => e.IDCompra);
            builder.Property(e => e.tipoDoc)
                .HasMaxLength(20);
            builder.Property(e => e.serie)
                .HasMaxLength(7);
            builder.Property(e => e.Numero)
                .HasMaxLength(10);
            builder.Property(e => e.fechaHora);
            builder.Property(e => e.impuesto);
            builder.Property(e => e.total);
            builder.Property(e => e.estado);
            builder.HasOne(w => w.usu)
                .WithOne();
            builder.HasOne(w => w.persona)
                .WithOne();
        }
    }
}