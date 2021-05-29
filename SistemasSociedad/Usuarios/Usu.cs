using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasSociedad.Usuarios
{
    class Usu
    {
        public int IDUsuario { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ERROR DE DATOS MAESTROS - USUARIO")]
        public string usuario { get; set; }
        [StringLength(100)]
        public string Tipo { get; set; }
        [StringLength(20)]
        public string Numero { get; set; }
        [StringLength(20)]
        public string Domicilio { get; set; }
        [StringLength(70)]
        public string telefono { get; set; }
        [StringLength(20)]
        public string Correo { get; set; }
        [StringLength(50)]
        public string password_hash { get; set; }
        public string password_sal { get; set; }
        public bool condicion { get; set; }
        public List<Rol> Roles { get; set; }
    }
}
