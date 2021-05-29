using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasData.Mapheo.Usuarios
{
    class Mp_rol : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("rol")
                .HasKey(g => g.IDRol);
            builder.Property(g => g.Nombre)
                 .HasMaxLength(50);
            builder.Property(g => g.Descripcion)
                .HasMaxLength(100);
            builder.Property(g => g.condicion);

        }
    }
}
