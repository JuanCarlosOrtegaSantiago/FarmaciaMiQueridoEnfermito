using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.COMMON
{
    public class Producto
    {
        public string categoria { get; set; }
        public string nombreDelProducto { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public string presentacion { get; set; }
        public float PrecioCompra { get; set; }
        public float PrecioVenta { get; set; } 

    }
}
