using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasSociedad.Bodega;
using SistemasSociedad.Ventas;
namespace SistemasSociedad.Ventas
{
    class VentaD
    {
        public int idVentaH { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "ERROR EN DATOS MAESTROS - VENTAS")]

        public string cantidad { get; set; }
        [StringLength(50)]
        public decimal PrecioU { get; set; }

        public decimal Descuento { get; set; }
        public List<VentaH> Ventas { get; set; }
        public List<Item> Item { get; set; }

    }
}
