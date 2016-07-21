using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion7
{
    public abstract class AbsClientes
    {
        public abstract int Id { get; set; }
        public abstract String Nombre { get; set; }
        public string Clave { get; set; }
        public abstract String DNI { get; set; }
        public abstract int TipoRegimen { get; set; }
        public abstract String NombreContacto { get; set; }
        
    }
}
