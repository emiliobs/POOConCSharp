using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion6._0
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientesVentas cliente = new _0.ClientesVentas();

            cliente.IdCliente = 555;
            cliente.Departamento = "Madrid";
            cliente.Apellidos = "Barrera Sepulveda";
            cliente.Direccion = "calle una 55";
            cliente.DNI = "98661097";
            cliente.EsCredito = true;
            cliente.Municipio = "Madrid";
            cliente.Nombres = "Emilio";
            Console.WriteLine($"{cliente.Apellidos}  {cliente.Nombres}");
            Console.WriteLine($"{cliente.Direccion}  {cliente.Departamento} {cliente.Municipio}");
            Console.WriteLine($"{cliente.DNI}");
            if (cliente.EsCredito)
            {
                Console.WriteLine("El cliente tiene Credito.");
            }
            else
            {
                Console.WriteLine("El cliente No Tiene Credido.");
            }

            Console.ReadKey();


        }
    }
}
