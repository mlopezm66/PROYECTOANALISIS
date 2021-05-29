using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasSociedad.Compra
{
    class Compra
    {
        public int IDCompra { get; set; }
        public string Tipo { get; set; }
        [StringLength(20)]
        public string Serie { get; set; }
        [StringLength(7)]
        public string Numero { get; set; }
        [StringLength(10)]
        public DateTime fechaHora { get; set; }
        public decimal impuesto { get; set; }

        public decimal Total { get; set; }

        public string estado { get; set; }

        public List<Usu> Usuarios { get; set; }
        public List<Persona> Persona { get; set; }
    }
}
