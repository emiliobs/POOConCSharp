using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion14Ling1;

namespace Presentacion14Ling1
{
    public class CtrPresentacion14
    {
        public List<ProductosInventario> productosInventario { get; set; }
        public CtrPresentacion14()
        {
            productosInventario = new List<ProductosInventario>();
        }


        public void LlernarLista()
        {
            productosInventario.Clear();

            productosInventario.Add(new ProductosInventario
            {
                ProductoId = 124,
                Clave = "P0001",
                Descripcion = "GTA CRACKERT 200G",
                PrecioPublico = 12.5,
                Costo = 11.5,
                Existencia = -20

            });

            productosInventario.Add(new ProductosInventario
            {
                ProductoId = 124,
                Clave = "P0001",
                Descripcion = "GTA CRACKERT 200G",
                PrecioPublico = 12.5,
                Costo = 11.5,
                Existencia = 0

            });
            productosInventario.Add(new ProductosInventario
            {
                ProductoId = 124,
                Clave = "P0001",
                Descripcion = "GTA CRACKERT 200G",
                PrecioPublico = 12.5,
                Costo = 11.5,
                Existencia = -8

            });
            productosInventario.Add( new ProductosInventario
            {
                    ProductoId = 124, 
                    Clave = "P0001",
                    Descripcion ="GTA CRACKERT 200G",
                    PrecioPublico = 12.5,
                    Costo=11.5,
                    Existencia=-5

            });

            productosInventario.Add(new ProductosInventario
            {
                ProductoId = 125,
                Clave = "P0002",
                Descripcion = "Cocacola",
                PrecioPublico = 3.5,
                Costo = 2.5,
                Existencia = 500

            });

            productosInventario.Add(new ProductosInventario
            {
                ProductoId = 124,
                Clave = "P0001",
                Descripcion = "GTA CRACKERT 200G",
                PrecioPublico = 12.5,
                Costo = 11.5,
                Existencia = 0

            });

            productosInventario.Add(new ProductosInventario
            {
                ProductoId = 126,
                Clave = "P0003",
                Descripcion = "Gatorade",
                PrecioPublico = 8.5,
                Costo = 5.5,
                Existencia = 300

            });

            productosInventario.Add(new ProductosInventario
            {
                ProductoId = 127,
                Clave = "P0004",
                Descripcion = "Lima Limon",
                PrecioPublico = 15.5,
                Costo = 9.5,
                Existencia = 555

            });

            productosInventario.Add(new ProductosInventario
            {
                ProductoId = 126,
                Clave = "P0003",
                Descripcion = "Gatorade",
                PrecioPublico = 8.5,
                Costo = 5.5,
                Existencia = 300

            });

            productosInventario.Add(new ProductosInventario
            {
                ProductoId = 128,
                Clave = "P0005",
                Descripcion = "Chia",
                PrecioPublico = 78.5,
                Costo = 12.5,
                Existencia = 1500

            });

            productosInventario.Add(new ProductosInventario
            {
                ProductoId = 127,
                Clave = "P0004",
                Descripcion = "Lima Limon",
                PrecioPublico = 15.5,
                Costo = 9.5,
                Existencia = 555

            });
        }

    }
}
