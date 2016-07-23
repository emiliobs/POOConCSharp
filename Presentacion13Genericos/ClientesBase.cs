using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion13Genericos
{
    public class ClientesBase : AbsClientes
    {
        public ClientesBase()
        {

        }
        public ClientesBase(int id, string nombre, string clave, string dNI, int tipoRegimen, string nombreContacto)
        {
            Id = id;
            Nombre = nombre;
            Clave = clave;
            DNI = dNI;
            TipoRegimen = tipoRegimen;
            NombreContacto = nombreContacto;
        }

       

        public override int Id
        {
            get;


            set;
        }

        public override string Nombre
        {
            get;


            set;
            
        }

        public override string DNI
        {
            get;


            set;
        }

        public override int TipoRegimen
        {
            get;


            set;
        }

        public override string NombreContacto
        {
            get;


            set;
        }

       
    }
}
