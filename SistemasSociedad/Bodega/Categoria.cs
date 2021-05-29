using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasSociedad.Bodega
{
    class Categoria
    {
        public int IdCategoria { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Error")]
        public string nombre { get; set; }
        [StringLength(256)]
        public string descripcion { get; set; }

        public bool condicion { get; set; }
        List<Articulo> Item { get; set; }
    }
}

