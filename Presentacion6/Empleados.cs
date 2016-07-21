using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    public class Empleados
    {
      

        public string Nombre { get; set; }
        public decimal SueldoDiario { get; set; }
        public int Edad { get; set; }


        public Empleados()
        {
            this.Nombre = string.Empty;
            this.SueldoDiario = 0.0m;
            this.Edad = 0;
        }

        public decimal CalculaSalario(int numeroDias)
        {
            return SueldoDiario * numeroDias;
        }
    }
}
