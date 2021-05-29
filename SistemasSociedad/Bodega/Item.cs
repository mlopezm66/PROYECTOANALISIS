using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasSociedad.Compra;

namespace SistemasSociedad.Bodega
{
    class Item
    {


        public int IdItem { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Error")]
        public string Codigo { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(50)]
        public decimal PrecioU { get; set; }
        public int stock { get; set; }
        public string Descripcion { get; set; }
        [StringLength(256)]
        public bool condicion { get; set; }
        //ESTA ES LA RELACION CON LA TABLA CATEGORIAS PARA HACER LA FK
        public List<Categoria> Categorias { get; set; }


    }
}
