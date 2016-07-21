using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion7
{
    public class ClientesConContatos : ClientesBase
    {
        public ClientesConContatos()
        {
            Direcciones = new Presentacion7.Direcciones();
        }

        public ClientesConContatos(int id, string nombre, string clave, string dNI, int tipoRegimen, string nombreContacto,
                                   string telefono, string telefono1, string email, string calle, string numeroExterior, 
                                   string numeroInterior, string departamento, string municipio, string estado, string cP)
        {
            Id = id;
            this.Nombre = nombre;
            this.Clave = clave;
            this.DNI = dNI;
            this.TipoRegimen = tipoRegimen;
            this.NombreContacto = nombreContacto;
            Telefono = telefono;
            Telefono1 = telefono1;
            Email = email;
           Direcciones = new Direcciones();
            Direcciones.Calle = calle;
            Direcciones.NumeroExterior = numeroExterior;
            Direcciones.NumeroInterior = numeroInterior;
            Direcciones.Departamento = departamento;
            Direcciones.Municipio = municipio;
            Direcciones.Estado = estado;
            Direcciones.CP = cP;
           
          
        }

        public string Telefono { get; set; }
        public string Telefono1 { get; set; }
        public string Email { get; set; }

        public Direcciones Direcciones { get; set; }


    }
}
