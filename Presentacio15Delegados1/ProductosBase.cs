using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacio15Delegados1
{
    public class ProductosBase : AbsProductos
    {
        public override int ProductoId
        {
            get;

            set;
        }
        public override string Clave
        {
            get;

            set;
            
        }

        public override string Descripcion
        {
            get;

            set;
        }

       
    }
}
