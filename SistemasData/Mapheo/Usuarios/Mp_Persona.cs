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
    class Mp_Persona : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Persona")
                .HasKey(f => f.DPI);
           
            builder.Property(f => f.PrimerNom)
                .HasMaxLength(100);
            builder.Property(f => f.SegndoNom)
                .HasMaxLength(100);
            builder.Property(f => f.Apellido1)
                .HasMaxLength(100);
            builder.Property(f => f.Apellido2)
                .HasMaxLength(100);
            builder.Property(f => f.tipoDocumento)
                .HasMaxLength(50);
            builder.Property(f => f.numDocumento)
                .HasMaxLength(70);
            builder.Property(f => f.telefono)
                .HasMaxLength(20);
            builder.Property(f => f.correo)
                .HasMaxLength(50);

        }
    }
}