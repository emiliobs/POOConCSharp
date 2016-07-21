using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.5m;
            bool bandera = true;
            string cadena = "12345";
            DateTime fecha = DateTime.MinValue;

            // x = i;

            //i = (int)x;

            //i = Convert.ToInt32(x);
            //i = Convert.ToInt32(bandera);
            i = Convert.ToInt32(cadena);

            Console.WriteLine($"{i}");
            Console.WriteLine($"{x,0:C}");
            Console.WriteLine($"{bandera.ToString()}");
            Console.WriteLine($"{cadena}");
            Console.WriteLine($"{fecha.ToShortDateString()}");

            Console.ReadKey();
        }
    }
}
