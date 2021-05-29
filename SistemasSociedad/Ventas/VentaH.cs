using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasSociedad.Usuarios;
namespace SistemasSociedad.Ventas
{
    class VentaH
    {
        public int IDVenta { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ERROR ENCABEZADO")]

        public string tipo { get; set; }
        [StringLength(20)]
        public string serie { get; set; }
        [StringLength(7)]
        public string numero { get; set; }
        [StringLength(10)]
        public DateTime fechaHora { get; set; }

        public decimal impuesto { get; set; }

        public decimal total { get; set; }

        public string estado { get; set; }

        public List<Persona> Personas { get; set; }
        public List<Usu> Usuarios { get; set; }

    }
}
