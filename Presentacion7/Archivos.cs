using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion7
{
    public class Archivos : intSalidas
    {
        public void ImprimeCliente(AbsClientes cliente)
        {
            StreamWriter sw = new StreamWriter(@"D:\documentos\ArchBitacora.log", true);
            sw.WriteLine(cliente.Clave + "  " + cliente.Nombre);
            if (cliente.TipoRegimen == 1)
            {
                sw.WriteLine("Tipo: PERSONA FISICA.");
            }
            else
            {
                sw.WriteLine("Tipo: PERSONA MORAL.");
            }

            sw.WriteLine("RFC: " + cliente.DNI);

            sw.Close();

        }

        public void ImprimirDireccion(Direcciones direccion)
        {
            StreamWriter ar = new StreamWriter(@"D:\documentos\ArchBitacora.log", true);
            ar.WriteLine(direccion.Calle + " " + direccion.NumeroExterior);
            ar.WriteLine(direccion.Departamento);
            ar.WriteLine(direccion.CP);
            ar.WriteLine(direccion.Estado);
            ar.Close();
        }
    }
}
