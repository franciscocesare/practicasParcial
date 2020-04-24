using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPizzeria
{
    public enum SaboresPizzas
    {
        Muzzarella,
        Napoliatana,
        Margarita,
        Cantinpalo,
        JamonYmorron
    }

    public enum TipoCoccion
    {
        Piedra,
        Molde,
        Media_Masa

    }
    public class Pedido
    {
        private Cliente cliente;
        private bool envia = false;
        private DateTime horaIngreso;
        private DateTime horaRetiro;
        private List <Pizza> pizzas; //array de pizza, nombre pizzas. 
                                //guardamos objetos pizza en el array, se instancia en el constr


        //CONSTRUCTORES!!!
        private Pedido(Cliente cliente)//le paso un cliente por param

        {
            this.cliente = cliente;
            this.pizzas = new List<Pizza>();
            
            //para haber un pedido tiene que haber un cliente
            //this.pizzas = new List <Pizza>(); //lo inicialiazamos lista
           // this.envia = false;
          //  this.horaIngreso = DateTime.Now; //se hace aca, en el constructor!!
        }

        #region Propiedades 

        public List <Pizza> Pizza
        {
            get
            {
                return this.pizzas;

            }
            set
            {
                this.pizzas = value;

            }
        }

        public DateTime HoraIngreso
        {
            get 
            { 
                return this.horaIngreso; 
            }
            set 
            { 
                this.horaIngreso = value; 
            }
        }

        public DateTime HoraRetiro
        {
            get
            {
                return this.horaRetiro;
            }
            set
            {
                this.horaRetiro = value;
            }
        }

        public bool Envio
        {
            get
            {

                return this.envia;
            }

            set
            {
                this.envia = value;

            }
        }

        public Cliente Cliente
        {

            get
            {
                return this.cliente;
            }
            set
            {

                this.cliente=value;
            }

        }

        #endregion

        public string MostrarPedido()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.HoraIngreso.ToString("HH:mm"));
            sb.AppendLine(this.Cliente.Nombre);
           // sb.AppendLine(this.pizzas.Countpizzas(); //TENGO MIS DUDAS DEL INDICE DE LA LISTA
            return sb.ToString();
        }

        public string GetGustoYCantidad()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Pizza item in this.pizzas)
            {
                if (!(item is null))
                {
                    sb.Append($"{item.Gusto}({item.Cantidad})");

                }

            }
            return sb.ToString();
        }

        #region sobrecarga de oepradores

        public static implicit operator Pedido(Cliente c)
        {

            return new Pedido(c); //nuevo pedido 

        }

        


        public static bool operator +(Pedido pedido, Pizza pizza)
        {
            //va a buscar en el array de piza existe, y si esta. la suma. sino va al otro For
            for (int i = 0; i < pedido.pizzas.Count; i++)
            {
                if (pedido.pizzas[i] + pizza)
                    return true;

            }
            
            //este bucle agrega si no existe, porque estaa null
            for (int i = 0; i < pedido.pizzas.Count; i++)

            {
                if (pedido.pizzas[i] is null)
                {

                    pedido.pizzas[i] = pizza; //en el indice null le agrego la pizza

                    return true; //la pudo agregar
                }
            }
            return false;
        }
        #endregion
    }



}

