
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados empleado = new Empleados();

            empleado.Nombre = "Emilio Barrera";
            empleado.SueldoDiario = 20.5m;
            empleado.Edad = 55;

            decimal total = empleado.CalculaSalario(30);
            Console.WriteLine($"El salario mensual del empleado es { empleado.Nombre}");
            Console.WriteLine("es: " + total.ToString("C"));

            Console.ReadKey();



        }
    }
}
