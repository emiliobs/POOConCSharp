using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion12HashMap
{
    public class MuestraHashTable
    {
        Hashtable Tabla;

        public MuestraHashTable()
        {
            Tabla = new Hashtable();
        }

       public void AgregarDatos()
        {
            Tabla.Add("Z123","Zina");
            Tabla.Add("R123", "Rojo");
            Tabla.Add("E123", "Emilio");
            Tabla.Add("M123", "Mary");
        }

        public void ImprimirDatos()
        {
            Console.Write("Existe {0} Elemento, dame la clave del producto: ", Tabla.Count);
            string dato = Console.ReadLine();

            if (Tabla[dato] == null)
            {
                Console.WriteLine("NO Existe elemnto.!!!!");
            }
            else
            {
                Console.Write("El Elemento Encontrado es: ");
                Console.WriteLine(Tabla[dato]);
            }
           
            Console.ReadKey();
        }

        public void Eliminarelemento(string key)
        {
            Tabla.Remove(key);
        }
    }
}
