using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion13Genericos;
namespace Presentacion13Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = string.Empty;
            string cadena = string.Empty;
            List<ClientesBase> clientes = new List<ClientesBase>();

            do
            {
                Console.WriteLine("Opciones:");
                Console.WriteLine("a. Agegar a la Lista.");
                Console.WriteLine("b. Quitar de la Lista.");
                Console.WriteLine("c. Imprimir Lista.");
                Console.WriteLine();
                Console.WriteLine("s. Salir.");
                opcion = Console.ReadLine();

                if (opcion == "a")
                {
                    Console.Write("Ingrese Cliente: ");
                    cadena = Console.ReadLine();
                    ClientesBase cliente = new ClientesBase();
                    cliente.Id = clientes.Count + 1;
                    cliente.Nombre = cadena;
                    clientes.Add(cliente);

                }
                else if (opcion == "b")
                {
                    cadena = Console.ReadLine();
                    clientes.RemoveAt(Convert.ToInt32(cadena));
                }
                else if (opcion == "c")
                {
                    foreach (ClientesBase cliente in clientes)
                    {
                        Console.WriteLine("Los datos del cliente son: ");
                        Console.WriteLine(cliente.Id.ToString() + " " + cliente.Nombre.ToString());
                    }

                    Console.ReadKey();
                }

            } while (opcion != "s");

           
            
        }
    }
}
