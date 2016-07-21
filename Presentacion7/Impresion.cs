using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion7
{
   public class Impresion:intSalidas
    {
       //static public void ImprimirCliente(AbsClientes cliente)
       // {
       //     Console.WriteLine(cliente.Id);
       //     Console.WriteLine(cliente.Nombre);
       //     Console.WriteLine(cliente.DNI);
       //     Console.WriteLine(cliente.Clave);
       //     Console.WriteLine(cliente.TipoRegimen);
       //     Console.WriteLine(cliente.NombreContacto);
          

       //     Console.ReadKey();
       // }

        public void ImprimeCliente(AbsClientes cliente)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);

            if (cliente.TipoRegimen == 1)
            {
                Console.WriteLine("Tipo: PERSONA FISICA.");
            }
            else
            {
                Console.WriteLine("Tipo: PERSONA MORAL.");
            }

            Console.WriteLine("RFC: " + cliente.DNI);

            Console.ReadKey();
        }

        public void ImprimirDireccion(Direcciones direccion)
        {
            Console.WriteLine(direccion.Calle  + " " + direccion.NumeroExterior);
            Console.WriteLine(direccion.Departamento);
            Console.WriteLine(direccion.CP);
            Console.WriteLine(direccion.Estado);

            Console.ReadKey();

        }

        //public void ImprimirCliente(ClientesConContatos cliente)
        //{
        //    Console.WriteLine(cliente.Id);
        //    Console.WriteLine(cliente.Nombre);
        //    Console.WriteLine(cliente.DNI);
        //    Console.WriteLine(cliente.Clave);
        //    Console.WriteLine(cliente.TipoRegimen);
        //    Console.WriteLine(cliente.NombreContacto);
        //    Console.WriteLine(cliente.Direcciones.CP);


        //    Console.ReadKey();
        //}
    }
}
