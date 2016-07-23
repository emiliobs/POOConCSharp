using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion14Ling1;
using System.Diagnostics;
namespace Presentacion14Ling1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch reloj = new Stopwatch();

            CtrPresentacion14 control = new Presentacion14Ling1.CtrPresentacion14();
            control.LlernarLista();

            Impresion.ImprimirProductosInventario(control.productosInventario);
            Impresion.EsperaTecla();

         

            List<ProductosInventario> productosInventario = new List<ProductosInventario>();
            reloj.Start();
            foreach (var productos in control.productosInventario)
            {
                if (productos.Existencia > 0 && productos.PrecioPublico < 12)
                {
                    productosInventario.Add(productos);
                }

                
            }

            reloj.Stop();
            Impresion.ImprimirTiempo(reloj.ElapsedTicks);

            Impresion.ImprimirProductosInventario(productosInventario);
            Impresion.EsperaTecla();

            List<ProductosInventario> productosList = new List<ProductosInventario>();
            reloj.Reset();
            reloj.Start();
            productosList.AddRange(from cp in control.productosInventario where cp.Existencia > 0 && cp.PrecioPublico < 12 select cp);
            reloj.Stop();
            Impresion.ImprimirProductosInventario(productosList);
            Impresion.ImprimirTiempo(reloj.ElapsedTicks);
            Impresion.EsperaTecla();

            //var lista2 = (from cp in control.productosInventario group cp by cp.Costo into g select g).ToList();
            //var lista2 = (from cp in control.productosInventario group cp by cp.Costo into g select new { g.Key, Total = g.Count()}).ToList();
            var lista2 = (from cp in control.productosInventario group cp by cp.Costo into g select new { g.Key, Total = g.Sum(t => t.Existencia * t.PrecioPublico) }).ToList();
            foreach (var lista in lista2)
            {
                Console.WriteLine($"Total: {lista.Total} Costo: {lista.Key}");
            }

            Impresion.EsperaTecla();
        }
    }
}
