using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesPizzeria;

namespace EntidadesPizzeria
{
    public class Cliente
    {
        private string apellido;
        private string nombre;
        private string domicilio;
       

        public Cliente(string nombre)
        {
            this.nombre = nombre;

        }

        public Cliente(string nombre, string domicilio) : this(nombre)
        {

            this.domicilio = domicilio;

        }

       

        public Cliente(string nombre, string apellido, string domicilio) : this(nombre, domicilio)
        {

            this.apellido = apellido;
        }

        public Cliente()
        {
        }

        public string MostrarCliente() //GETTER???
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine( apellido);
            sb.AppendLine("," + nombre);
           // sb.AppendFormat("Direccion : {0}", domicilio);
            return sb.ToString();

        }

        public void SetNombre(string nombre)
        {
            this.nombre=nombre;
        }

        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void SetDomicilio(string domicilio)
        {
            this.domicilio =domicilio;
        }


        public static Cliente CrearCliente(string nombre, string apellido, string domicilio)
        {
            return new Cliente(nombre, apellido, domicilio);
        }

       

        public static bool operator == (Cliente clienteA, Cliente clienteB)
        {
           
           return ((clienteA.apellido == clienteB.apellido) && (clienteA.domicilio == clienteB.domicilio));
         
        }
        public static bool operator !=(Cliente clienteA, Cliente clienteB)
        {
            return !((clienteA.apellido == clienteB.apellido) && (clienteA.domicilio == clienteB.domicilio));

        }

        


    }
}
