using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SistemasSociedad.Bodega;

namespace SistemasSociedad.Compra
{
    class CompraD
    {
        public int IdCompraH { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Error")]
        public int cantidad { get; set; }

        public decimal PrecioU { get; set; }

        public List<Compra> Compra { get; set; }
        public List<Item> Articulos { get; set; }
    }
}

