using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasSociedad.Usuarios
{
    class Rol
    {
        public int idRol { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ERROR DE DATOS MAESTROS")]
        public string nombreRol { get; set; }
        [StringLength(50)]
        public string descripcionRol { get; set; }
        [StringLength(100)]
        public bool condicion { get; set; }
    }
}
