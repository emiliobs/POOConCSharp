using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion8
{
    public class Archivos : intSalidas
    {
        public void ImprimeCliente(AbsClientes cliente)
        {
            int i = 0;
            bool bandera = true;
            while (bandera)
            {
                try
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

                    //aqui se sale del ciclo:
                    bandera = false;
                }
                catch (Exception ex)
                {
                    //En este contador el doy em margen de espera para que salga del ciclo:
                    i++;
                    if (i >= 1000)
                    {
                        throw ex;
                    }

                    
                } 
            }

        }

        public void ImprimirDireccion(Direcciones direccion)
        {
            try
            {
                StreamWriter ar = new StreamWriter(@"D:\documentos\ArchBitacora.log", true);
                ar.WriteLine(direccion.Calle + " " + direccion.NumeroExterior);
                ar.WriteLine(direccion.Departamento);
                ar.WriteLine(direccion.CP);
                ar.WriteLine(direccion.Estado);
                ar.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
