using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemasSociedad.Usuarios
{
    class Persona
    {
        public int DPI { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ERROR DE DATOS MAESTROS")]
        public string tipo { get; set; }
        [StringLength(20)]
        public string PrimerNom { get; set; }
        [StringLength(100)]
        public string SegundoNom { get; set; }
        [StringLength(100)]
        public string Apellido1 { get; set; }
        [StringLength(100)]
        public string Apellido2 { get; set; }
        [StringLength(100)]
        public string TipoDoc { get; set; }
        [StringLength(50)]
        public string Numero { get; set; }
        [StringLength(70)]
        public string Telefono { get; set; }
        [StringLength(20)]
        public string Correo { get; set; }
    }
}
