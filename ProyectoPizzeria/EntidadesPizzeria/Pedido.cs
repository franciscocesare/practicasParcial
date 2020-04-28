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
        public List <Pizza> pizzas; //lista de pizza, nombre pizzas. 
                                //guardamos objetos pizza en el array, se instancia en el constr


        //CONSTRUCTORES!!!
        public Pedido(Cliente cliente, List<Pizza> pizzas): this(cliente)//le paso un cliente por param

        {
           // this.cliente = cliente;
            this.pizzas = pizzas; //le dpu un limite a la lista?
           
        }

        public Pedido(Cliente cliente)
        {
            this.cliente = cliente;
            this.pizzas = new List<Pizza>();

        }

        #region Propiedades 

        public List<Pizza> PropPizzas
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
            sb.Append(HoraIngreso.ToString("HH:MM"));
            sb.Append(this.Cliente.Apellido);
            sb.Append(this.Cliente.Nombre);
            sb.Append(this.GetGustoYCantidad());//TENGO MIS DUDAS DEL INDICE DE LA LISTA
            return sb.ToString();
        }

        public string GetGustoYCantidad()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Pizza item in this.pizzas)
            {
                if (!(item is null))
                {
                    sb.Append($"{item.Gusto}{item.Cantidad}{item.TipoCoccion}");
                }

            }
            return sb.ToString();
        }

        #region sobrecarga de oepradores

        public static implicit operator Pedido(Cliente c)
        {

            return new Pedido(c); //nuevo pedido 

        }

        
        ///// ACA ME HACE ERROR EN EJECUCION, LLEGA EN NULL? LA LISTA

        public static bool operator + (Pedido pedido, Pizza pizza)
        {
            //va a buscar en el array de piza existe, y si esta. la suma. sino va al otro For
            //desde que lo hice list tengo errores
            for (int i = 0; i < pedido.pizzas.Count; i++)
            {
                if (pedido.pizzas[i]+ pizza)
                    return true;

            }

            ///NO PUEDO HACER QUE LA SOBRECARGA DE OPERADORES ME DEEVUELVA UN NUEVO PEDIDO???


            //este bucle agrega si no existe, porque estaa null

            pedido.pizzas.Add(pizza);   //la agrego directamenteeee
            return true;

            
        }
        #endregion
    }



}

