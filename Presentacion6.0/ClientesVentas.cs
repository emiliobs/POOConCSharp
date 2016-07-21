using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion6._0
{
    public class ClientesVentas:Clientes
    {
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public bool EsCredito { get; set; }
    }
}
