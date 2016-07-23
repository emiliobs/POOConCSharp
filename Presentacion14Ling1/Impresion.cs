using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion14Ling1
{
    public static class Impresion
    {
        public static void ImprimirProductosInventario(List<ProductosInventario> ProductosInventario)
        {
            foreach (var productoInventario in ProductosInventario)
            {
                Console.WriteLine($"Código:{productoInventario.ProductoId} Desripción:{productoInventario.Descripcion} Precio:{productoInventario.PrecioPublico} Costo:{productoInventario.Costo} Existencia:{productoInventario.Existencia} "
                                  );
            }
            Console.WriteLine("------------------------------------------------------------------------------------------");

        }

        public static void ImprimirTiempo(long time)
        {
            Console.WriteLine($"El tiempo transcurrido en tics de reloj es de:  {time}");
        }

        public static void EsperaTecla()
        {
            Console.ReadKey();
        }

    }
}
