using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemasSociedad.Users;

namespace SistemasData.Mapheo.Usuarios
{
    class Mp_usu : IEntityTypeConfiguration<Usu>
    {
        public void Configure(EntityTypeBuilder<Usu> builder)
        {
            builder.ToTable("Usu")
                 .HasKey(h => h.idUsu);
            builder.Property(h => h.nombreUsu)
                .HasMaxLength(100);
            builder.Property(h => h.tipoDocumento)
                .HasMaxLength(20);
            builder.Property(h => h.numDocumento)
                .HasMaxLength(20);
            builder.Property(h => h.domicilio)
                .HasMaxLength(70);
            builder.Property(h => h.telefono)
                .HasMaxLength(20);
            builder.Property(h => h.correo)
                .HasMaxLength(50);
            builder.Property(h => h.password_hash);
            builder.Property(h => h.password_sal);
            builder.Property(h => h.condicion);
            builder.HasOne(v => v.Rol)
                .WithOne();

        }
    }
}