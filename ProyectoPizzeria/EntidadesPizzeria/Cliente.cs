using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
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
            sb.AppendLine( Apellido);
            sb.AppendLine("," + Nombre);
           
            return sb.ToString();

        }

       public string Apellido
        {
            get
            {
                return this.apellido;

            }
            set
            {
                this.apellido = value;

            }
        
        }

        public string Nombre
        {
            get
            {

                return this.nombre;
            }
            set
            {
                this.nombre = value;

            }
        }

        public string Domicilio
        {

            get
            {
                return this.domicilio;
                
            }
            set
            {
                this.domicilio = value;

            }
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
