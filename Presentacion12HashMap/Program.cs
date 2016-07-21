using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion12HashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            MuestraHashTable muestra = new MuestraHashTable();

            muestra.AgregarDatos();
            muestra.ImprimirDatos();
            muestra.Eliminarelemento("M123");
            muestra.ImprimirDatos();
        }
    }
}
