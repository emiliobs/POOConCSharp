using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacio15Delegados1
{
   public abstract class AbsProductos
    {
        public abstract int ProductoId { get; set; }
        public abstract string  Clave { get; set; }
        public abstract string Descripcion { get; set; }
    }
}
