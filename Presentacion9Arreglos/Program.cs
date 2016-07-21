using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion9Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arreglo = new int[12];

            string cadena;
            //Aqui lleno el arreglo:
            for (int i = 0; i < 12; i++)
            {
                cadena = Console.ReadLine();
                Arreglo[i] = Convert.ToInt32(cadena); ;
            }

            //Aqui imprimo los datos del arreglo:
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"{Arreglo[i]}");
            }


            Console.ReadKey();
           
        }
    }
}
