using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Presentacio15Delegados1
{
    public delegate void MostrarAvance(string valor);

    public class ArchivosProductos
    {
        //objecto delegado:
        public event MostrarAvance avance;

        public void ObtenerProductos(List<ProductosBase> Productos)
        {
            StreamReader sr = new StreamReader(@"C:\Users\LaNave\Desktop\BD.txt");
            string cadena = sr.ReadLine();
            //para el delegado:
            int i = 1;
            while (cadena != null)
            {
                string [] campos = cadena.Split(',');
                ProductosBase productos = new ProductosBase();
                productos.ProductoId = Convert.ToInt32(campos[0]);
                productos.Clave = campos[1];
                productos.Descripcion = campos[2];
                Productos.Add(productos);

                //delegado:
                avance(i.ToString());
                i++;
                cadena = sr.ReadLine();
            }

            sr.Close();
        }
    }
}
