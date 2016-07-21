using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion10Arreglos
{
    public class ClasMatriz
    {
        private int[,] Matriz;

        public ClasMatriz()
        {
            Matriz = new int[5, 2];
        }

        public void InicializarMatriz()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Matriz[i, j] = 5;
                }
            }
        }

        public void ImprimirMatriz()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{Matriz[i,j].ToString()}");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
