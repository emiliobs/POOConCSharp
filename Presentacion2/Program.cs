using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.0d;
            string cadena = "Hola emilio";
            bool bandera = false;
            DateTime fecha = DateTime.MinValue;

            Console.WriteLine($"El valor de  i: {i}");
            Console.WriteLine("El valor de x es: {0:C}", x);
            Console.WriteLine($"El valor de  x: {x,0:C}");
            Console.WriteLine($"El valor de  f: {f,0:F2}");
            Console.WriteLine($"El valor de  d: {d,0:F2}");
            Console.WriteLine($"El valor de  cadena es: {cadena}");
            Console.WriteLine($"El valor de  bandera es: {bandera.ToString()}");
            Console.WriteLine($"El valor de  Fecha: {fecha.ToShortDateString()}");

            Console.ReadKey();
        }
    }
}
