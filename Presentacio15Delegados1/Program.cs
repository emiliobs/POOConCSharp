using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacio15Delegados1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProductosBase> productos = new List<Presentacio15Delegados1.ProductosBase>();
            ArchivosProductos archivo = new Presentacio15Delegados1.ArchivosProductos();

            archivo.avance += Archivo_avance;
            archivo.ObtenerProductos(productos);

            Console.ReadKey();

            foreach (var prod in productos)
            {
                Console.WriteLine($"Producto ID:{prod.ProductoId} Clave:{prod.Clave} Descripción:{prod.Descripcion}");
            }
            Console.ReadKey();

        }

        private static void Archivo_avance(string valor)
        {
            Console.WriteLine(valor); 
        }
    }
}
