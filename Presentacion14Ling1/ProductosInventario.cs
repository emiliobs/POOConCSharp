using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion14Ling1
{
   public class ProductosInventario
    {
        public int ProductoId { get; set; }
        public string  Clave { get; set; }
        public string Descripcion { get; set; }
        public double PrecioPublico { get; set; }
        public double Costo { get; set; }
        public int Existencia { get; set; }
    }
}
