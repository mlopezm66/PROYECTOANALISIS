using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sistemasSociedad.Compra;
using sistemasSociedad.Bodega;


namespace SistemasData.Mapheo.Bodega
{
    class Mp_Categoria : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria")
                .HasKey(a => a.idcategoria);
            builder.Property(a => a.nombre)
            .HasMaxLength(50);
            builder.Property(a => a.descripcion)
                .HasMaxLength(256);
            builder.Property(b => b.condicion);
        }
    }
}