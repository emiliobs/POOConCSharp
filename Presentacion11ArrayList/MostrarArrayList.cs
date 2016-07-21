using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion11ArrayList
{
   public class MostrarArrayList
    {

        ArrayList lists;

        public MostrarArrayList()
        {
            lists = new ArrayList();
        }

        public void CaturaDatos()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingresa Datos {i + 1}:");
                string dato = Console.ReadLine();
                lists.Add(dato);
            }
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("*****************************************************************************");

            foreach (var list in lists)
            {
                Console.WriteLine(list);
            }

            Console.ReadKey();
        }
    }
}
