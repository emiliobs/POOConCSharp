using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion8
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientesConContatos cliente = new ClientesConContatos(5, "Emilio", "458", "986654", 2, "POO", "5555555555",
                                                                "66666666660", "Barera_emilio@yahoo.es", "calle luna 5", "7854", "2365",
                                                                "Madrid", "Madrid", "España", "28004");

         
            intSalidas impresion;
            string cadena = Console.ReadLine();
            if (cadena == "1")
            {
                impresion = new Impresion();
            }
            else
            {
                impresion = new Archivos();
            }

            try
            {
                impresion.ImprimeCliente(cliente);
                impresion.ImprimirDireccion(cliente.Direcciones);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ocurrio un Error: " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}
